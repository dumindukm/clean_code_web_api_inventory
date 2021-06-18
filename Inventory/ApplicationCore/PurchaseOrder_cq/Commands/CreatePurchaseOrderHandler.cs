using ApplicationCore.Repository;
using AutoMapper;
using Domain.Models;
using Domain.PurchaseOrders.Events;
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
        private readonly IRepository<Product> productRepository;
        private readonly IMapper mapper;
        public CreatePurchaseOrderHandler(IRepository<PurchaseOrder> porepository, IRepository<Product> prepository, IMapper map)
        {
            this.purchaseorderRepository = porepository;
            this.productRepository = prepository;
            this.mapper = map;
        }
        public async Task<int> Handle(CreatePurchaseOrder request, CancellationToken cancellationToken)
        {
            PurchaseOrder po = new PurchaseOrder
            {
                StoreId = request.StoreId
            };

            foreach (var item in request.OrderedItems)
            {
                var product = await productRepository.GetByIdAsync(item.ProductId);
                po.AddOrderItem(new PurchaseOrderItem { 
                    Quantity = item.Quantity,
                    Discount = item.Discount,
                    UnitPrice = product.UnitPrice,
                    ProductCode = product.Code,
                    ProductId = product.Id
                });
            }
            po.AddDomainEvent(new PurchaseOrderCreated(po.Id, po.OrderCount, po.Total));

            await purchaseorderRepository.AddAsync(po);
            return po.Id;
        }
    }
}
