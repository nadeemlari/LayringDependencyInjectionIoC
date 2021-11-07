using System.Collections.Generic;

namespace WeatherApp.BLL
{
    public interface IWeatherService
    {
        IEnumerable<WeatherForecast> Get(string cityName, int numberOfDays);
    }
}