using System;
using System.Threading.Tasks;
using backend.Application.Repositories;
using backend.Domain.Entities.Common;
using backend.Persistence.Contexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;

namespace backend.Persistence.Repositories;

public class WriteRepository<T>(AppDbContext context) : IWriteRepository<T> where T : BaseEntity
{
    private readonly AppDbContext _context = context
;

    public DbSet<T> Table => _context.Set<T>();


    public async Task<bool> AddAsync(T model)
    {
        EntityEntry<T> entityEntry = await Table.AddAsync(model);
        return entityEntry.State == EntityState.Added;
    }

    public async Task<bool> AddRangeAsync(List<T> models)
    {
        await Table.AddRangeAsync(models);
        return true;
    }

    public bool Remove(T model)
    {
        EntityEntry<T> entityEntry = Table.Remove(model);
        return entityEntry.State == EntityState.Deleted;
    }

    public bool RemoveRange(List<T> models)
    {
        Table.RemoveRange(models);
        return true;
    }

    public async Task<bool> RemoveByIdAsync(string id)
    {
        T modelToRemove = await Table.FirstOrDefaultAsync(data => data.Id == Guid.Parse(id));
        return Remove(modelToRemove);
    }



    public bool Update(T model)
    {
        EntityEntry<T> entityEntry = Table.Update(model);
        return entityEntry.State == EntityState.Modified;
    }

    public Task<int> SaveAsync() => _context.SaveChangesAsync();

}
