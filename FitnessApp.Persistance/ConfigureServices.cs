using FitnessApp.Application.Interfaces;
using FitnessApp.Application.Interfaces.UnitOfWork;
using FitnessApp.Infrastucture.Persistence;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace FitnessApp.Persistence
{
    public static class ConfigureServices
    {
        public static IServiceCollection AddInfrastructureServices(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<DatabaseService>(options =>
            options.UseSqlServer(configuration.GetConnectionString("DefaultConnection"),
            builder => builder.MigrationsAssembly(typeof(DatabaseService).Assembly.FullName)));

            services.AddScoped<IDatabaseService>(provider => provider.GetRequiredService<DatabaseService>());
            services.AddScoped<DatabaseInitialiser>();

            services.AddScoped<IUnitOfWork, FitnessApp.Persistence.UnitOfWork.UnitOfWork>();

            return services;
        }
    }
}
