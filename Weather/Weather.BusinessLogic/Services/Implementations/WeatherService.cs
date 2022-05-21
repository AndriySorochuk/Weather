using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Weather.BusinessLogic.Models;
using Weather.BusinessLogic.Services.Interfaces;

namespace Weather.BusinessLogic.Services.Implementations
{
    internal class WeatherService : IWeatherService
    {
        public WeatherService()
        {

        }

        public Task<IEnumerable<WeatherModel>> GetWeatherAsync(string locationId)
        {
            throw new NotImplementedException();
        }
    }
}
