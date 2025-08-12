using System;
using backend.Domain.Entities;
using backend.Domain.Entities.Common;
using Microsoft.EntityFrameworkCore;

namespace backend.Persistence.Contexts;

public class AppDbContext(DbContextOptions options) : DbContext(options)
{
    public DbSet<Product> Products { get; set; }
    public DbSet<Order> Orders { get; set; }
    public DbSet<Customer> Customers { get; set; }


    public override async Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
    {
        var data = ChangeTracker.Entries<BaseEntity>();

        foreach (var item in data)
        {
            _ = item.State switch
            {
                EntityState.Added => item.Entity.CreatedAt = DateTime.UtcNow,
                EntityState.Modified => item.Entity.UpdatedAt = DateTime.UtcNow,
            };
        }

        return await base.SaveChangesAsync(cancellationToken);
    }
}
