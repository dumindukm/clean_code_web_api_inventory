using ApplicationCore.Repository;
using Domain.Models;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ApplicationCore.PurchaseOrder_cq.Commands
{
    public class CreatePurchaseOrderHandler : IRequestHandler<CreatePurchaseOrder, int>
    {
        private readonly IRepository<PurchaseOrder> purchaseorderRepository;
        public CreatePurchaseOrderHandler(IRepository<PurchaseOrder> repository)
        {
            this.purchaseorderRepository = repository;
        }
        public Task<int> Handle(CreatePurchaseOrder request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
