using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Weather.BusinessLogic.Helpers.Implementations;
using Weather.BusinessLogic.Helpers.Interfaces;
using Weather.BusinessLogic.Services.Implementations;
using Weather.BusinessLogic.Services.Interfaces;
using Weather.Database;

namespace Weather.BusinessLogic
{
    public static class Startup
    {
        public static IServiceCollection ConfigureBusinessLogic(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddScoped<ILocationsService, LocationsService>();
            services.AddScoped<IWeatherService, WeatherService>();
            services.AddScoped<IAccuWeatherHelper, AccuWeatherHelper>();
            services.AddHttpClient("AccuWeather", (x) => 
            {
                x.BaseAddress = new Uri("http://dataservice.accuweather.com/");//configuration.GetValue<string>("ApiSettings:ApiName:Uri")
            });

            services.ConfigureDatabase(configuration);

            return services;
        }
    }
}