using Microsoft.EntityFrameworkCore;
using Sklep.Database.Models;
using EFCore.NamingConventions;

namespace Sklep.Database
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext()
            : base() { }

        public DbSet<Product> Products { get; set; }
        public DbSet<ProductCategory> Categories { get; set; }
        public DbSet<ProductGroup> ProductGroups { get; set; }
        public DbSet<InventoryPosition> InventoryPositions { get; set; }
        public DbSet<InventoryChange> InventoryChanges { get; set; }
        public DbSet<ReceiptPosition> ReceiptItems { get; set; }
        public DbSet<Receipt> Receipts { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>().ToTable("product");
            modelBuilder.Entity<ProductCategory>().ToTable("product_category");
            modelBuilder.Entity<ProductGroup>().ToTable("product_group");
            modelBuilder.Entity<InventoryPosition>().ToTable("inventory_position");
            modelBuilder.Entity<InventoryChange>().ToTable("inventory_change");
            modelBuilder.Entity<ReceiptPosition>().ToTable("receipt_position");
            modelBuilder.Entity<Receipt>().ToTable("receipt");
            base.OnModelCreating(modelBuilder);
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) =>
            optionsBuilder
                .UseNpgsql(DatabaseConnectionSettings.FromEnv().GetConnectionString())
                .UseSnakeCaseNamingConvention();
    }
}
