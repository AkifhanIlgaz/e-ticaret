using System;
using backend.Domain.Entities.Common;

namespace backend.Application.Repositories;

public interface IWriteRepository<T> : IRepository<T> where T : BaseEntity
{

    Task<bool> AddAsync(T model);
    Task<bool> AddRangeAsync(List<T> model);
    bool Remove(T model);
    bool RemoveRange(List<T> models);
    Task<bool> RemoveByIdAsync(string id);
    bool Update(T model);
    Task<int> SaveAsync();

}
