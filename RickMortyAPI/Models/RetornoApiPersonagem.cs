
using System.Text.Json.Serialization;

public class Info2
{
	[JsonPropertyName("count")]
	public int Contar { get; set; }

	[JsonPropertyName("pages")]
	public int Paginas { get; set; }

	[JsonPropertyName("next")]
	public string Proxima { get; set; }

	[JsonPropertyName("prev")]
	public object Anterior { get; set; }
}

public class Location
{
	[JsonPropertyName("name")]
	public string Nome { get; set; }

	[JsonPropertyName("url")]
	public string Url { get; set; }
}

public class Origin
{
	[JsonPropertyName("name")]
	public string Nome { get; set; }

	[JsonPropertyName("url")]
	public string Url { get; set; }
}

public class Personagem
{
	[JsonPropertyName("id")]
	public int Id { get; set; }

	[JsonPropertyName("name")]
	public string Nome { get; set; }

	[JsonPropertyName("status")]
	public string Status { get; set; }

	[JsonPropertyName("species")]
	public string Especies { get; set; }

	[JsonPropertyName("type")]
	public string Tipo { get; set; }

	[JsonPropertyName("gender")]
	public string Genero { get; set; }

	[JsonPropertyName("origin")]
	public Origin Origem { get; set; }

	[JsonPropertyName("location")]
	public Location Localizacao { get; set; }

	[JsonPropertyName("image")]
	public string Imagem { get; set; }

	[JsonPropertyName("episode")]
	public List<string> Episodios { get; set; }

	[JsonPropertyName("url")]
	public string Url { get; set; }

	[JsonPropertyName("created")]
	public DateTime Criado { get; set; }
}

public class RetornoApiPersonagem
{
	[JsonPropertyName("info")]
	public Info2 Info2 { get; set; }

	[JsonPropertyName("results")]
	public List<Personagem> Results { get; set; }
}

