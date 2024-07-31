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

public class Localizacao
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

public class RetornoApiLocalizacaoDTO
{
	[JsonPropertyName("info")]
	public Info Info { get; set; }

	[JsonPropertyName("results")]
	public List<Localizacao> Results { get; set; }
}

