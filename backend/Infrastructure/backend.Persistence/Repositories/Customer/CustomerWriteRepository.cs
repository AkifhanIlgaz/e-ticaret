using System;
using backend.Application.Repositories;
using backend.Domain.Entities;
using backend.Persistence.Contexts;

namespace backend.Persistence.Repositories;

public class CustomerWriteRepository(AppDbContext context) : WriteRepository<Customer>(context), ICustomerWriteRepository
{
}
