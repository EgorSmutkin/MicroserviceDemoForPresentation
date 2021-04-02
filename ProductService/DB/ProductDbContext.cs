using Microsoft.EntityFrameworkCore;
using ProductService.DB.Entities;

namespace ProductService.DB
{
    public class ProductDbContext : DbContext
    {
        public ProductDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Product> Products { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            var products = new[] {
                new Product { Id = 1, Name = "Apple", Price = 42.74m },
                new Product { Id = 2, Name = "Banana", Price = 13.14m },
            };
            modelBuilder.Entity<Product>().HasData(products);

            base.OnModelCreating(modelBuilder);
        }
    }
}
