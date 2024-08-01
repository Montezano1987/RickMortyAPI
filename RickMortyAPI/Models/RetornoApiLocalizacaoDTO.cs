using System.Text.Json.Serialization;

public class Info
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

public class Localizacao
{
	[JsonPropertyName("id")]
	public int Id { get; set; }

	[JsonPropertyName("name")]
	public string Nome { get; set; }

	[JsonPropertyName("type")]
	public string Tipo { get; set; }

	[JsonPropertyName("dimension")]
	public string Dimensao { get; set; }

	[JsonPropertyName("residents")]
	public List<string> Residentes { get; set; }

	[JsonPropertyName("url")]
	public string Url { get; set; }

	[JsonPropertyName("created")]
	public DateTime Criado { get; set; }
}

public class RetornoApiLocalizacaoDTO
{
	[JsonPropertyName("info")]
	public Info Info { get; set; }

	[JsonPropertyName("results")]
	public List<Localizacao> Results { get; set; }
}

