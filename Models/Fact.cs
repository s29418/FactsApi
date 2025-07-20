using System.Text.Json.Serialization;

namespace FactsApi.Models;

public class Fact
{
    [JsonPropertyName("fact")]
    public string FactText { get; set; }
    public int Length { get; set; }
}