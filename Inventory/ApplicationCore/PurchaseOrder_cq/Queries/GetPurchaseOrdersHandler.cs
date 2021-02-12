using ApplicationCore.Repository;
using Domain.Models;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ApplicationCore.PurchaseOrder_cq.Queries
{
    public class GetPurchaseOrdersHandler : IRequestHandler<GetPurchaseOrders, IEnumerable<PurchaseOrder>>
    {
        private readonly IRepository<PurchaseOrder> poRepository;

        public GetPurchaseOrdersHandler(IRepository<PurchaseOrder> repository)
        {
            poRepository = repository;
        }

        public async Task<IEnumerable<PurchaseOrder>> Handle(GetPurchaseOrders request, CancellationToken cancellationToken)
        {
            return await poRepository.ListAllAsync();
        }
    }
}
