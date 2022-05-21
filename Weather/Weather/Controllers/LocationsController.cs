using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Weather.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LocationsController : ControllerBase
    {
        private readonly ILogger<LocationsController> _logger;
        public LocationsController(ILogger<LocationsController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public async Task<IActionResult> SearchAsync([FromQuery] string name)
        {

            return null;
        }
    }
}
