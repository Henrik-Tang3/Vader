using System.Text.Json.Serialization;

namespace Väder.Models
{
    public class InstantData
    {
        [JsonPropertyName("details")]
        public InstantDetails? Details { get; set; }
    }
}
