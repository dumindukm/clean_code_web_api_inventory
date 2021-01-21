using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using Domain.Models;
using ApplicationCore.Repository;
using System.Threading.Tasks;
using System.Threading;

namespace ApplicationCore.Store_cq.Queries
{
    public class GetStoresHandler : IRequestHandler<GetStores, IEnumerable<Store>>
    {
        //private readonly IStoreRepository storeRepository;
        //public GetStoresHandler(IStoreRepository repository)
        //{
        //    storeRepository = repository;
        //}

        //public async Task<IEnumerable<Store>> Handle(GetStores request, CancellationToken cancellationToken)
        //{
        //    return await this.storeRepository.ListAllAsync();
        //}

        private readonly IRepository<Store> storeRepository;

        public GetStoresHandler(IRepository<Store> repository)
        {
            storeRepository = repository;
        }

        public async Task<IEnumerable<Store>> Handle(GetStores request, CancellationToken cancellationToken)
        {
            return await this.storeRepository.ListAllAsync();
        }
    }
}
