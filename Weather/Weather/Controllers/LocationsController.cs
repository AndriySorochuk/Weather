using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Weather.BusinessLogic.Services.Interfaces;

namespace Weather.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LocationsController : ControllerBase
    {
        private readonly ILogger<LocationsController> logger;
        private readonly ILocationsService locationsService;

        public LocationsController(ILogger<LocationsController> logger, ILocationsService locationsService)
        {
            this.logger = logger;
            this.locationsService = locationsService;
        }

        [HttpGet]
        public async Task<IActionResult> SearchAsync([FromQuery] string name)
        {
            var result = await locationsService.SearchAsync(name);
            return Ok(result);
        }
    }
}
