using Domain.SeedWork;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.PurchaseOrders.Events
{
    public class PurchaseOrderCreated : DomainEventBase
    {
        public PurchaseOrderCreated(int id , int orderCount, decimal total)
        {
            this.Id = id;
            this.OrderCount = orderCount;
            this.Total = total;
        }

        public int Id { get; set; }
        public int OrderCount { get; set; }
        public decimal Total { get; set; }
    }
}
