using System;
using backend.Application.Repositories;
using backend.Domain.Entities;
using backend.Persistence.Contexts;

namespace backend.Persistence.Repositories;

public class OrderReadRepository(AppDbContext context) : ReadRepository<Order>(context), IOrderReadRepository
{
}
