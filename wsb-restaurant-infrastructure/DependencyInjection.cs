using Microsoft.Extensions.DependencyInjection;
using wsb_restaurant_application.Common.Interfaces;
using wsb_restaurant_infrastructure.Authentication;
using Microsoft.Extensions.Configuration;

namespace wsb_restaurant_infrastructure
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection services, ConfigurationManager configuration)
        {
            services.Configure<JwtAppSettings>(configuration.GetSection("JwtSettings"));
            services.AddSingleton<IJwtTokenGenerator, JwtTokenGenerator>();

            return services;
        }
    }
}
