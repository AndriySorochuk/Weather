using Microsoft.AspNetCore.Mvc;
using Weather.BusinessLogic.Services.Interfaces;

namespace Weather.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherController : ControllerBase
    {

        private readonly ILogger<WeatherController> logger;
        private readonly IWeatherService weatherService;

        public WeatherController(ILogger<WeatherController> logger, IWeatherService weatherService)
        {
            this.logger = logger;
            this.weatherService = weatherService;
        }

        [HttpGet]
        public async Task<IActionResult> GetWeatherAsync([FromQuery]int locationId, [FromQuery] int days)
        {
            var results = await weatherService.GetWeatherAsync(locationId, days);
            return Ok(results);
        }
    }
}