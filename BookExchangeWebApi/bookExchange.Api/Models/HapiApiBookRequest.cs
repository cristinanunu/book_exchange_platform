using System.Text.Json.Serialization;

namespace bookExchange.Api.Models;

public class HapiApiBookRequest
{
    [JsonPropertyName("book_id")]
    public string Book_id { get; set; }
    
    [JsonPropertyName("name")]
    public string Name { get; set; }
    
    [JsonPropertyName("category")]
    public string Category { get; set; }
    
    [JsonPropertyName("cover")]
    public string Cover { get; set; }
    
    [JsonPropertyName("url")]
    public string Url { get; set; }
}