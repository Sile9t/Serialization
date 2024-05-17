using System.Xml.Serialization;

namespace Serialization
{
    public class JsonSerial
    {
        public class WeatherInfo
        {
            public DateTime Time { get; set; }
            public double Temperature { get; set; }
            public int Weathercode { get; set; }
            public double Windspeed { get; set; }
            public int Winddirection { get; set; }
        }
        public class Weather
        {
            public WeatherInfo? Current { get; set; }
            public List<WeatherInfo> History { get; set; }
        }
    }
}
