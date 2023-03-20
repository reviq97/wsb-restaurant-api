
using Microsoft.Extensions.DependencyInjection;
using wsb_restaurant_application.Services.Authentication;

namespace wsb_restaurant_application
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddApplication(this IServiceCollection services)
        {
            services.AddScoped<IAuthenticationService, AuthenticationService>();

            return services;
        }
    }
}
