using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Weather.Database
{
    public static class Startup
    {
        public static IServiceCollection ConfigureDatabase(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<WeatherDBContext>(x=>x.UseSqlServer(configuration.GetConnectionString("WeatherDB")));

            return services;
        }
    }
}