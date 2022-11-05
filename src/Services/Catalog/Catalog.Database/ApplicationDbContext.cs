using Catalog.Database.Configuration;
using Catalog.Domain;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Catalog.Database
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.HasDefaultSchema("Catalog");
            ModelConfig(builder);
        }

        private void ModelConfig(ModelBuilder builder)
        {
            new ProductConfiguration(builder.Entity<Product>());
            new ProductConfiguration(builder.Entity<Product>());
        }

        //Mis entidades
        public DbSet<Product> Products { get; set; }
        public DbSet<ProductStock> Stocks { get; set; }
    }
}
