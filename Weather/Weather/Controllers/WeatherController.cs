using Microsoft.AspNetCore.Mvc;

namespace Weather.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherController : ControllerBase
    {

        private readonly ILogger<WeatherController> _logger;

        public WeatherController(ILogger<WeatherController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public async Task<IActionResult> GetWeatherAsync()
        {
            return null;
        }
    }
}