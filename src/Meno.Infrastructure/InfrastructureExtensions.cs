using Meno.Core.Entities;
using Meno.Infrastructure.Abstractions;
using Meno.Infrastructure.DAL.Repositories.InMemory;
using Meno.Infrastructure.Exceptions;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Meno.Infrastructure
{
    public static class InfrastructureExtensions
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddControllers();
            services.AddSingleton<ExceptionMidelware>();

            // Repositories
            services.AddScoped<IRepository<Category>, InMemoryCategoryRepository>();
            services.AddScoped<IRepository<MenuItem>, InMemoryMenuItemRepository>();
            services.AddScoped<IRepository<Menu>, InMemoryMenuRepository>();
            services.AddScoped<IRepository<Place>, InMemoryPlaceRepository>();
            services.AddScoped<IRepository<User>, InMemoryUserRepository>();

            // Rest

            return services;
        }

        public static WebApplication UseInfrastructure(this WebApplication app)
        {
            app.UseMiddleware<ExceptionMidelware>();
            app.MapControllers();

            return app;
        }
    }
}