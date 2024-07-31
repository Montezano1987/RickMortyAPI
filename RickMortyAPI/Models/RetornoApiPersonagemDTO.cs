
using System.Text.Json.Serialization;

public class Info2
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

public class Location
{
	[JsonPropertyName("name")]
	public string Name { get; set; }

	[JsonPropertyName("url")]
	public string Url { get; set; }
}

public class Origin
{
	[JsonPropertyName("name")]
	public string Name { get; set; }

	[JsonPropertyName("url")]
	public string Url { get; set; }
}

public class Personagem
{
	[JsonPropertyName("id")]
	public int Id { get; set; }

	[JsonPropertyName("name")]
	public string Name { get; set; }

	[JsonPropertyName("status")]
	public string Status { get; set; }

	[JsonPropertyName("species")]
	public string Species { get; set; }

	[JsonPropertyName("type")]
	public string Type { get; set; }

	[JsonPropertyName("gender")]
	public string Gender { get; set; }

	[JsonPropertyName("origin")]
	public Origin Origin { get; set; }

	[JsonPropertyName("location")]
	public Location Location { get; set; }

	[JsonPropertyName("image")]
	public string Image { get; set; }

	[JsonPropertyName("episode")]
	public List<string> Episode { get; set; }

	[JsonPropertyName("url")]
	public string Url { get; set; }

	[JsonPropertyName("created")]
	public DateTime Created { get; set; }
}

public class RetornoApiPersonagemDTO
{
	[JsonPropertyName("info")]
	public Info2 Info2 { get; set; }

	[JsonPropertyName("results")]
	public List<Personagem> Results { get; set; }
}

