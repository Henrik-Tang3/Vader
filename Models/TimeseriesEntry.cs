using System.Text.Json.Serialization;

namespace Väder.Models
{
    public class TimeseriesEntry
    {
        [JsonPropertyName("time")]
        public DateTime Time { get; set; }

        [JsonPropertyName("data")]
        public WeatherData? Data { get; set; }
    }
}
