using System;
using System.Collections.Generic;
using System.Linq;

using WeatherApp.BLL;

namespace WeatherApp.DAL
{
    public class DummyWeatherDataRepositry : IWeatherDataRepositry
    {
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };
        public IEnumerable<WeatherForecast> Get(string cityName, int numberOfDays)
        {
            return GetData(numberOfDays)
                .Select(dto => new WeatherForecast
                {
                    Date = dto.Date,
                    Summary = dto.Summary,
                    TemperatureC = dto.Temperature
                });
        }

        private static IEnumerable<WeatherForecastDto> GetData(int numberOfDays)
        {
            var rng = new Random();
            return Enumerable.Range(1, numberOfDays).Select(index => new WeatherForecastDto
            {
                Date = DateTime.Now.AddDays(index),
                Temperature = rng.Next(-20, 55),
                Summary = Summaries[rng.Next(Summaries.Length)]
            })
            .ToArray();
        }

    }
}
