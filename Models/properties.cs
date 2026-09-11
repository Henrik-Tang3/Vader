using System.Text.Json.Serialization;

namespace Väder.Models
{
    public class Properties
    {
        [JsonPropertyName("timeseries")]
        public List<TimeseriesEntry>? Timeseries { get; set; }
    }
}
