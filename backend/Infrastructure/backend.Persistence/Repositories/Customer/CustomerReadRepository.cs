using System;
using backend.Application.Repositories;
using backend.Domain.Entities;
using backend.Domain.Entities.Common;
using backend.Persistence.Contexts;

namespace backend.Persistence.Repositories;

public class CustomerReadRepository(AppDbContext context) : ReadRepository<Customer>(context), ICustomerReadRepository
{
}
