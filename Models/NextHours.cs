using System.Text.Json.Serialization;

namespace Väder.Models
{
    public class NextHours
    {
        [JsonPropertyName("summary")]
        public Summary? Summary { get; set; }
    }
}
