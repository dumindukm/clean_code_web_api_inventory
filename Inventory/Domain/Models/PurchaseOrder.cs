using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Domain.Models
{
    public class PurchaseOrder
    {
        public int Id { get; set; }
        public int OrderCount => PurchaseOrderItems.Count();
        public decimal Total => PurchaseOrderItems.Sum(item => item.Total);
        public List<PurchaseOrderItem> PurchaseOrderItems { get; private set; }  = new List<PurchaseOrderItem>();

        public void AddOrderItem(PurchaseOrderItem item) => PurchaseOrderItems.Add(item);

        public int StoreId { get; set; }
        public Store Store { get; set; }
    }
}
