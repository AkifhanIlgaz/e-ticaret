using System;
using backend.Application.Abstractions;
using backend.Persistence.Concretes;
using backend.Persistence.Contexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace backend.Persistence;

public static class ServiceRegistration
{
    public static void AddPersistenceServices(this IServiceCollection services)
    {
        services.AddSingleton<IProductService, ProductService>();
        services.AddDbContext<AppDbContext>(options => options.UseNpgsql(Configuration.ConnectionString));
    }
}
