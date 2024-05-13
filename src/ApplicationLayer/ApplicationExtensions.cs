using FluentValidation;
using Microsoft.Extensions.DependencyInjection;

namespace ApplicationLayer
{
    public static class ApplicationExtensions
    {
        public static IServiceCollection AddApplicationExtension(this IServiceCollection services)
        {
            var assembly = typeof(ApplicationExtensions).Assembly;

            services.AddMediatR(configuration => configuration.
                RegisterServicesFromAssemblies(assembly));

            services.AddValidatorsFromAssembly(assembly);

            return services;
        }
    }
}
