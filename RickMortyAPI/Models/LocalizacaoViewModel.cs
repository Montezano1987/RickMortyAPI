// Root myDeserializedClass = JsonSerializer.Deserialize<Root>(myJsonResponse);
using System.Text.Json.Serialization;

public class Info
{
    [JsonPropertyName("count")]
    public int Count { get; set; }

    [JsonPropertyName("pages")]
    public int Pages { get; set; }

    [JsonPropertyName("next")]
    public string Next { get; set; }

    [JsonPropertyName("prev")]
    public object Prev { get; set; }
}

public class LocalizacaoViewModel
{
    [JsonPropertyName("id")]
    public int Id { get; set; }

    [JsonPropertyName("name")]
    public string Name { get; set; }

    [JsonPropertyName("type")]
    public string Type { get; set; }

    [JsonPropertyName("dimension")]
    public string Dimension { get; set; }

    [JsonPropertyName("residents")]
    public List<string> Residents { get; set; }

    [JsonPropertyName("url")]
    public string Url { get; set; }

    [JsonPropertyName("created")]
    public DateTime Created { get; set; }
}

public class LocalizacaoResponse
{
    [JsonPropertyName("info")]
    public Info Info { get; set; }

    [JsonPropertyName("results")]
    public List<LocalizacaoViewModel> Results { get; set; }
}


