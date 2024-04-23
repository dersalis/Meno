using Meno.Core.Entities;
using Meno.Infrastructure.Abstractions;
using Meno.Infrastructure.DAL.Repositories.InMemory;
using Meno.Infrastructure.Exceptions;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.OpenApi.Models;

namespace Meno.Infrastructure
{
    public static class InfrastructureExtensions
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddControllers();
            services.AddSingleton<ExceptionMidelware>();
            services.AddHttpContextAccessor();

            // Repositories
            services.AddScoped<IRepository<Category>, InMemoryCategoryRepository>();
            services.AddScoped<IRepository<MenuItem>, InMemoryMenuItemRepository>();
            services.AddScoped<IRepository<Menu>, InMemoryMenuRepository>();
            services.AddScoped<IRepository<Place>, InMemoryPlaceRepository>();
            services.AddScoped<IRepository<User>, InMemoryUserRepository>();

            // Swagger
            services.AddSwaggerGen(swagger => 
            {
                swagger.EnableAnnotations();
                swagger.SwaggerDoc("v1", new OpenApiInfo
                {
                    Title = "WasteControl API",
                    Version = "v1"
                });
            });

            // Rest         
            services.AddEndpointsApiExplorer();

            return services;
        }

        public static WebApplication UseInfrastructure(this WebApplication app)
        {
            app.UseMiddleware<ExceptionMidelware>();
            
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            // app.UseSwagger();
            // app.UseSwaggerUI();
            // app.UseReDoc(reDoc => 
            // {
            //     reDoc.RoutePrefix = "docs";
            //     reDoc.DocumentTitle = "WasteControl API";
            //     reDoc.SpecUrl = "/swagger/v1/swagger.json";
            // });

            // app.UseAuthentication();
            // app.UseAuthorization();
            app.MapControllers();

            return app;
        }
    }
}