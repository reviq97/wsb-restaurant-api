using Microsoft.AspNetCore.Mvc;

namespace wsb_restaurant_api.Controllers
{
    [ApiController]
    [Route("api/v1/restaurant")]
    public class RestaurantController : ControllerBase
    {

        private readonly ILogger<RestaurantController> _logger;

        public RestaurantController(ILogger<RestaurantController> logger)
        {
            _logger = logger;
        }

        [HttpGet(Name = "GetWeatherForecast")]
        public void Get()
        {
            
        }
    }
}