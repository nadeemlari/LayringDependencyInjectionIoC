using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

using System.Collections.Generic;

using WeatherApp.BLL;

namespace WeatherApp.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private readonly IWeatherService service;

        public WeatherForecastController( IWeatherService service)
        {
            this.service = service;
        }

        [HttpGet]
        public IEnumerable<WeatherForecast> Get(string cityName = "Bangalore", int numberOdDays = 3)
        {
            return service.Get(cityName, numberOdDays);

        }
    }
}
