using System.Text.Json.Serialization;

namespace Väder.Models
{
    public class InstantDetails
    {
        [JsonPropertyName("air_temperature")]
        public double AirTemperature { get; set; }

        [JsonPropertyName("wind_speed")]
        public double WindSpeed { get; set; }
    }
}
