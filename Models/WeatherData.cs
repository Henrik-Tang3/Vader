using System.Text.Json.Serialization;

namespace Väder.Models
{
    public class WeatherData
    {
        [JsonPropertyName("instant")]
        public InstantData? Instant { get; set; }

        [JsonPropertyName("next_1_hours")]
        public NextHours? Next1Hours { get; set; }

        [JsonPropertyName("next_6_hours")]
        public NextHours? Next6Hours { get; set; }

        [JsonPropertyName("next_12_hours")]
        public NextHours? Next12Hours { get; set; }
    }
}
