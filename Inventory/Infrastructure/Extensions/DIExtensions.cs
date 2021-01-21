using ApplicationCore.Repository;
using Infrastructure.Repository;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;
using Alachisoft.NCache.Caching.Distributed;
using Domain.Models;

namespace Infrastructure.Extensions
{
    public static class DIExtensions
    {
        public static IServiceCollection AddInfrastructureDependencies(this IServiceCollection services, bool isDevelopmemnt)
        {
            services.AddScoped(typeof(IRepository<>), typeof(EfCoreRepository<>));
            services.AddScoped(typeof(IRepository<Store>), typeof(EfCoreRepository<Store>));
            services.Decorate<IRepository<Store>, StoreCachedRepository>();
            if (isDevelopmemnt)
            {
                services.AddDbContext<InventoryDbContext>(opt => opt.UseInMemoryDatabase(databaseName: "InventoryDB"));
            }

            services.AddNCacheDistributedCache(configuration =>
            {
                configuration.CacheName = "inventoryCache";
                configuration.EnableLogs = true;
                configuration.ExceptionsEnabled = true;
            });

            return services;
        }
            

    }
}
