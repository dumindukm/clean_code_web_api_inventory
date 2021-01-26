using ApplicationCore.Repository;
using Domain.Models;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ApplicationCore.Store_cq.Commands
{
    public class CreateStoreOrderHandler : IRequestHandler<CreateStore, int>
    {
        private readonly IRepository<Store> storeRepository;

        public CreateStoreOrderHandler(IRepository<Store> repository) => storeRepository = repository;
        public async Task<int> Handle(CreateStore request, CancellationToken cancellationToken)
        {
            Store store = new Store
            {
                Name = request.Name,
                Address = request.Address
            };

            await storeRepository.AddAsync(store);

            return store.Id;

        }
    }
}
