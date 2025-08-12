using System;
using System.Linq.Expressions;
using backend.Application.Repositories;
using backend.Domain.Entities.Common;
using backend.Persistence.Contexts;
using Microsoft.EntityFrameworkCore;

namespace backend.Persistence.Repositories;

public class ReadRepository<T>(AppDbContext context) : IReadRepository<T> where T : BaseEntity
{
    private readonly AppDbContext _context = context;

    public DbSet<T> Table => _context.Set<T>();

    public IQueryable<T> GetAll() => Table;
    public IQueryable<T> GetWhere(Expression<Func<T, bool>> method) => Table.Where(method);
    public async Task<T> GetSingleAsync(Expression<Func<T, bool>> method) => await Table.FirstOrDefaultAsync(method);

    public async Task<T> GetByIdAsync(string id) => await Table.FirstOrDefaultAsync(data => data.Id == Guid.Parse(id));



}
