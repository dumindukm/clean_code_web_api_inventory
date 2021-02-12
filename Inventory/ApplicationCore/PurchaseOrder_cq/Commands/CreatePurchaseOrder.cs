using Domain.Models;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace ApplicationCore.PurchaseOrder_cq.Commands
{
    public class CreatePurchaseOrder : IRequest<int>
    {
        public int StoreId { get; set; }
        public IEnumerable<OrderItem> OrderedItems { get; set; }
    }
    public class OrderItem
    {
        public int ProductId { get; set; }
        public int Quantity { get; set; }
        public decimal Discount { get; set; }
    }
}
