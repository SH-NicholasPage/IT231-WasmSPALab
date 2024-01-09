using BlazorApp.Shared;
using Microsoft.AspNetCore.Mvc;

namespace BlazorApp.Server.Controllers
{

    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private const int NUM_OF_DAYS_IN_FORECAST = 5;

        private static readonly String[] Summaries =
        {
            "Freezing", "Chilly", "Cool", "Mild", "Warm", "Hot", "Sweltering", "Scorching"
        };

        private ILogger<WeatherForecastController> Logger { get; }

        public WeatherForecastController(ILogger<WeatherForecastController> logger)
        {
            Logger = logger;
        }

        [HttpGet]
        public List<WeatherForecast> Get()
        {
            List<WeatherForecast> forecast = [];

            for(int i = 0; i < NUM_OF_DAYS_IN_FORECAST; i++)
            {
                forecast.Add(new WeatherForecast
                {
                    Date = DateTime.Now.AddDays(i + 1),
                    TemperatureC = Random.Shared.Next(-20, 55),
                    Summary = Summaries[Random.Shared.Next(Summaries.Length)]
                });
            }

            return forecast;
        }
    }
}