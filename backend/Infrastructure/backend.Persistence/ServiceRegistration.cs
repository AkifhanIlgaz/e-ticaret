using System;
using backend.Application.Abstractions;
using backend.Persistence.Concretes;
using Microsoft.Extensions.DependencyInjection;

namespace backend.Persistence;

public static class ServiceRegistration
{
    public static void AddPersistenceServices(this IServiceCollection services)
    {
        services.AddSingleton<IProductService, ProductService>();
    }
}
