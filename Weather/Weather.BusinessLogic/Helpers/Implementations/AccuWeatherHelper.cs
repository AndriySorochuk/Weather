using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Weather.BusinessLogic.Helpers.Interfaces;
using Weather.BusinessLogic.Models;

namespace Weather.BusinessLogic.Helpers.Implementations
{
    internal class AccuWeatherHelper: IAccuWeatherHelper
    {
        private readonly HttpClient httpClient;
        public AccuWeatherHelper(IHttpClientFactory factory)
        {
            this.httpClient = factory.CreateClient("AccuWeather");
        }

        ///<inheritdoc />
        public async Task<IEnumerable<WeatherModel>> GetAccuWeatherAsync(int locationId)
        {
            var apiKey = "";//TODO: add to env variable
            var response = await httpClient.GetAsync($"forecasts/v1/daily/1day/{locationId}?apikey={apiKey}");
            
            response.EnsureSuccessStatusCode();
            var json = await response.Content.ReadAsStringAsync();

            return null;
        }
    }
}
