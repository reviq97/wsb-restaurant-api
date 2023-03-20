using Microsoft.Extensions.DependencyInjection;
using wsb_restaurant_application.Common.Interfaces.Authentication;
using wsb_restaurant_infrastructure.Authentication;

namespace wsb_restaurant_infrastructure
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection services)
        {
            services.AddSingleton<IJwtTokenGenerator, JwtTokenGenerator>();

            return services;
        }
    }
}
