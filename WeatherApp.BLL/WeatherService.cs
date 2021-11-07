using System.Collections.Generic;

namespace WeatherApp.BLL
{
    public class WeatherService : IWeatherService
    {
        private readonly IWeatherDataRepositry repositry;

        public WeatherService(IWeatherDataRepositry repositry)
        {
            this.repositry = repositry;
        }
        public IEnumerable<WeatherForecast> Get(string cityName, int numberOfDays)
        {
            return repositry.Get(cityName, numberOfDays);

        }
    }
}
