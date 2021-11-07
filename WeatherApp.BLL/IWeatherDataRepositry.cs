using System.Collections.Generic;

namespace WeatherApp.BLL
{
    public interface IWeatherDataRepositry
    {
        IEnumerable<WeatherForecast> Get(string cityName, int numberOfDays);
    }
}