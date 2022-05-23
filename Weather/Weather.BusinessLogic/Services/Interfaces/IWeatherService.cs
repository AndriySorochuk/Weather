using Weather.BusinessLogic.Models;

namespace Weather.BusinessLogic.Services.Interfaces
{
    public interface IWeatherService
    {
        Task<IEnumerable<WeatherModel>> GetWeatherAsync(int locationId, int days);
    }
}
