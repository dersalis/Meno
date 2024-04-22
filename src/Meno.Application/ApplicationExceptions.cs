using System.Reflection;
using Meno.Application.Implementations;
using Meno.Infrastructure.Abstractions;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Meno.Application
{
    public static class ApplicationExceptions
    {
        public static IServiceCollection AddApplication(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddMediatR(cfg => cfg.RegisterServicesFromAssembly(Assembly.GetExecutingAssembly()));
            services.AddSingleton<IDateTimeProvider, DateTimeProvider>();

            return services;
        }
    }
}