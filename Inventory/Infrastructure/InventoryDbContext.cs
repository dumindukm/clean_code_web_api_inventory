using Domain.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace Infrastructure
{
    public class InventoryDbContext : DbContext
    {
        public InventoryDbContext(DbContextOptions<InventoryDbContext> options) : base(options)
        {
        }

        public DbSet<Product> Baskets { get; set; }
        public DbSet<PurchaseOrderItem> CatalogItems { get; set; }
        public DbSet<PurchaseOrder> CatalogBrands { get; set; }
        public DbSet<Supplier> CatalogTypes { get; set; }
        public DbSet<Store> Orders { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }
    }
}
