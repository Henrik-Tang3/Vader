using System.Text.Json.Serialization;

namespace Väder.Models
{
    public class Summary
    {
        [JsonPropertyName("symbol_code")]
        public string? SymbolCode { get; set; }
    }
}
