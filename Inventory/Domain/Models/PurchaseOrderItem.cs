using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Models
{
    public class PurchaseOrderItem
    {
        public int Id { get; set; }

        public int Quantity { get; set; }
        public decimal UnitPrice { get; set; }
        public decimal Discount { get; set; }
        public decimal Total => (Quantity * UnitPrice) - Discount;


        public Product Product { get; set; }
        public int ProductId { get; set; }
        public string ProductCode { get; set; }

        public PurchaseOrder PurchaseOrder { get; set; }
        public int PurchaseOrderId { get; set; }
    }
}
