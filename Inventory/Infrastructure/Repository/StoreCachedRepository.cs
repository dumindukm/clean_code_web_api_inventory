using ApplicationCore.Repository;
using Domain.Models;
using Microsoft.Extensions.Caching.Distributed;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Repository
{
    public class StoreCachedRepository: EfCoreRepository<Store> , IRepository<Store>
    {
        private readonly IRepository<Store> storeRepository;
        //private readonly IDistributedCache cacheService;
        private IReadOnlyList<Store> stores;
        public StoreCachedRepository(IRepository<Store> storeRepository, InventoryDbContext context):base(context)
        {
            this.storeRepository = storeRepository;
            //this.cacheService = cacheService;
        }

        public override async Task<IReadOnlyList<Store>> ListAllAsync()
        {
            // TO DO : USE distributed cache : https://docs.microsoft.com/en-us/aspnet/core/performance/caching/distributed?view=aspnetcore-5.0
            // IDistributedCache cacheService inject in constructor and configure NCache
            if (stores == null)
            {
                stores = await storeRepository.ListAllAsync();
            }
            return stores;
        }

    }
}
