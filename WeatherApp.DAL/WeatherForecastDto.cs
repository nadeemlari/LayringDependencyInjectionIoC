using System;

namespace WeatherApp.DAL
{
    public class WeatherForecastDto
    {
        public DateTime Date { get; set; }

        public int Temperature { get; set; }

        public string Summary { get; set; }
    }
}
