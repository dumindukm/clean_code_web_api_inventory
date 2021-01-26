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
        public IEnumerable<OrderItem> OrderedItems => new List<OrderItem>();
    }
    public class OrderItem
    {
        public string ProductCode { get; set; }
        public int Quantity { get; set; }
        public decimal UnitPrice { get; set; }
        public decimal Discount { get; set; }
    }
}
