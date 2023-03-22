﻿using Microsoft.EntityFrameworkCore;
using Sklep.Database.Models;
using EFCore.NamingConventions;

namespace Sklep.Database
{
    internal class DatabaseContext : DbContext
    {
        public DatabaseContext() : base() { }

        public DbSet<Product> Products { get; set; }
        public DbSet<ProductCategory> Categories { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>().ToTable("product");
            modelBuilder.Entity<ProductCategory>().ToTable("product_category");

            base.OnModelCreating(modelBuilder);
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) =>
            optionsBuilder
            .UseNpgsql(DatabaseConnectionSettings.FromEnv().GetConnectionString())
            .UseSnakeCaseNamingConvention();

        
    }
}