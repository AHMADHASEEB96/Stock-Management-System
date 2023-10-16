using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace Stock_Management
{
    public partial class Model4 : DbContext
    {
        public Model4()
            : base("name=Model116")
        {
        }

        public virtual DbSet<Admin> Admins { get; set; }
        public virtual DbSet<Customer> Customers { get; set; }
        public virtual DbSet<ExportedItem> ExportedItems { get; set; }
        public virtual DbSet<Product> Products { get; set; }
        public virtual DbSet<ProductsCategory> ProductsCategories { get; set; }
        public virtual DbSet<RemovedItem> RemovedItems { get; set; }
        public virtual DbSet<Supplier> Suppliers { get; set; }
        public virtual DbSet<SupplyOrder> SupplyOrders { get; set; }
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }
        public virtual DbSet<TransferredItem> TransferredItems { get; set; }
        public virtual DbSet<Warehouse> Warehouses { get; set; }
        public virtual DbSet<ExportingOrder> ExportingOrders { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Customer>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<Customer>()
                .Property(e => e.Mail)
                .IsUnicode(false);

            modelBuilder.Entity<Customer>()
                .HasMany(e => e.ExportedItems)
                .WithRequired(e => e.Customer)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<ExportedItem>()
                .Property(e => e.ExportedQuantity)
                .HasPrecision(18, 0);

            modelBuilder.Entity<Product>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<Product>()
                .Property(e => e.Price)
                .HasPrecision(18, 0);

            modelBuilder.Entity<Product>()
                .Property(e => e.Quantity)
                .HasPrecision(18, 0);

            modelBuilder.Entity<Product>()
                .Property(e => e.TotalItemPrice)
                .HasPrecision(18, 0);

            modelBuilder.Entity<Product>()
                .Property(e => e.ValidationPeriod)
                .HasPrecision(18, 0);

            modelBuilder.Entity<Product>()
                .HasMany(e => e.ExportedItems)
                .WithRequired(e => e.Product)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Product>()
                .HasMany(e => e.Warehouses)
                .WithMany(e => e.Products)
                .Map(m => m.ToTable("ProductWarehouse").MapLeftKey("ProductId").MapRightKey("WarehouseId"));

            modelBuilder.Entity<RemovedItem>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<RemovedItem>()
                .Property(e => e.Price)
                .HasPrecision(18, 0);

            modelBuilder.Entity<RemovedItem>()
                .Property(e => e.Quantity)
                .HasPrecision(18, 0);

            modelBuilder.Entity<RemovedItem>()
                .Property(e => e.ValidationPeriod)
                .HasPrecision(18, 0);

            modelBuilder.Entity<Supplier>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<Supplier>()
                .Property(e => e.Mail)
                .IsUnicode(false);

            modelBuilder.Entity<Supplier>()
                .HasMany(e => e.SupplyOrders)
                .WithMany(e => e.Suppliers)
                .Map(m => m.ToTable("ProductSupplyOrder").MapLeftKey("ProductId").MapRightKey("SupplyOrderId"));

            modelBuilder.Entity<TransferredItem>()
                .Property(e => e.Quantity)
                .HasPrecision(18, 0);

            modelBuilder.Entity<Warehouse>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<Warehouse>()
                .Property(e => e.Adress)
                .IsUnicode(false);

            modelBuilder.Entity<ExportingOrder>()
                .Property(e => e.ExportedQuantity)
                .HasPrecision(18, 0);
        }
    }
}
