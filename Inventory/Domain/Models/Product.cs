﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public bool IsActive { get; set; }
        public int StockLevel { get; set; }
        public decimal UnitPrice { get; set; }

        public int SupplierId { get; set; }
        public Supplier Supplier { get; set; }
    }
}
