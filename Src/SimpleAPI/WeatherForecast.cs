using System;

namespace SimpleAPI
{
    /*Comment here*/
    /*Comment here*/
    /*Comment here*/
    /*Comment here*/
    /*Comment here*/
    /*Comment here*/
    /*Comment here* /
    public class WeatherForecast
    {
        public DateTime Date { get; set; }

        public int TemperatureC { get; set; }

        public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);

        public string Summary { get; set; }
    }
}
