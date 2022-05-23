using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Weather.BusinessLogic.Models;

namespace Weather.BusinessLogic.Helpers.Interfaces
{
    public interface IAccuWeatherHelper
    {
        /// <summary>
        /// Gets weather from AccuWeather for Location
        /// </summary>
        /// <param name="locationId">AccuWeather Id of location</param>
        /// <returns>Forecast for 15days</returns>
        Task<IEnumerable<WeatherModel>> GetAccuWeatherAsync(int locationId);
    }
}
