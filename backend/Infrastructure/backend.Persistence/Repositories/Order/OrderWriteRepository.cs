using System;
using backend.Application.Repositories;
using backend.Domain.Entities;
using backend.Persistence.Contexts;

namespace backend.Persistence.Repositories;

public class OrderWriteRepository(AppDbContext context) : WriteRepository<Order>(context), IOrderWriteRepository
{
}
