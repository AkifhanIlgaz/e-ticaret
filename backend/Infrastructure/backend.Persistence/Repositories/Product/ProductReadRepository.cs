using System;
using backend.Application.Repositories;
using backend.Domain.Entities;
using backend.Persistence.Contexts;

namespace backend.Persistence.Repositories;

public class ProductReadRepository(AppDbContext context) : ReadRepository<Product>(context), IProductReadRepository
{
}
