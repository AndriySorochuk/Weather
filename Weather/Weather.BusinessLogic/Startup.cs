using Microsoft.Extensions.DependencyInjection;
using Weather.BusinessLogic.Services.Implementations;
using Weather.BusinessLogic.Services.Interfaces;

namespace Weather.BusinessLogic
{
    public static class Startup
    {
        public static IServiceCollection ConfigureBusinessLogic(this IServiceCollection services)
        {
            services.AddScoped<ILocationsService, LocationsService>();
            services.AddScoped<IWeatherService, WeatherService>();

            return services;
        }
    }
}