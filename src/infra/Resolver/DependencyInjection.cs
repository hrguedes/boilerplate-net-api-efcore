using Application.Company;
using Application.Company.Interfaces;
using Consts;
using Data.Context;
using Data.Repositories;
using Entities.Intefaces;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Resolver;

public static class DependencyInjection
{
    public static IServiceCollection AddInfrastructure(this IServiceCollection services, IConfiguration configuration)
    {
        // Database
        services.AddDbContext<AppContextDB>(options =>
            options.UseLazyLoadingProxies()
                .UseSqlServer(LaunchSettings.ConnectionString,
                    b => b.MigrationsAssembly(typeof(AppContextDB).Assembly.FullName)));

        // Services
        services.AddScoped<ICompanyService, CompanyService>();

        // Repositories
        services.AddScoped<ICompanyRepository, CompanyRepository>();

        // Integrations

        // massTransit

        // return
        return services;
    }
}