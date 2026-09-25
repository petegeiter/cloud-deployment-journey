using Microsoft.AspNetCore.Mvc;

namespace aws_api_demo.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private static readonly string[] Summaries =
        [
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        ];

        [HttpGet("hello")]
        public IActionResult Hello()
        {
            return Ok(new { message = "Hello from AWS API Demo!" });
        }
    }
}
