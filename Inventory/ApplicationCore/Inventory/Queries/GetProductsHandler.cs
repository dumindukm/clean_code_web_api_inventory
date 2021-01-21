using Domain.Models;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Linq;
using ApplicationCore.Repository;

namespace ApplicationCore.Inventory.Queries
{
    public class GetProductsHandler : IRequestHandler<GetProducts, IEnumerable<Product>>
    {
        private readonly IRepository<Product> productRepository;
        public GetProductsHandler(IRepository<Product> repository)
        {
            productRepository = repository;
        }
        public async Task<IEnumerable<Product>> Handle(GetProducts request, CancellationToken cancellationToken)
        {
            return await this.productRepository.ListAllAsync();
        }
    }
}
