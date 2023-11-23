using Entities.Models;
using Microsoft.EntityFrameworkCore;

namespace Repositories;
public class RepositoryContext : DbContext
{
    public RepositoryContext(DbContextOptions<RepositoryContext> options)
     : base(options)
    {

    }
    public DbSet<Product> Products { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.Entity<Product>()
        .HasData(
             new Product()
             {
                 ProductId = 1,
                 ProductName = "Computer",
                 Price = 30_000
             },
                new Product()
                {
                    ProductId = 2,
                    ProductName = "Phone",
                    Price = 40_000
                },
                new Product()
                {
                    ProductId = 3,
                    ProductName = "Mouse",
                    Price = 1_000
                }
        );
    }
}