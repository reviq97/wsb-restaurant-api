using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using wsb_restaurant_dal.Context;

namespace wsb_restaurant_dal
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddApplicationDbContext(this IServiceCollection services)
        {
            services.AddDbContext<ApplicationDbContext>(options => options.UseNpgsql("Host=localhost:5432;Database=postgres;Username=postgres;Password=admin", b => b.MigrationsAssembly("wsb-restaurant-api")));

            return services;
        }
    }
}
