using System.Text.Json.Serialization;

namespace Väder.Models
{
    public class WeatherForecast
    {
        [JsonPropertyName("properties")]
        public Properties? Properties { get; set; }
    }
}
