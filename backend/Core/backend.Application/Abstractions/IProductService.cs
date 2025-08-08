using System;
using backend.Domain.Entities;

namespace backend.Application.Abstractions;

public interface IProductService
{
    List<Product> GetProducts();
}
