using System.Text.Json.Serialization;
using RickMortyAPI.ViewModel;


namespace RickMortyAPI.Models
{
	public class Info
	{
		[JsonPropertyName("count")]
		public int Contar { get; set; }

		[JsonPropertyName("pages")]
		public int Paginas { get; set; }

		[JsonPropertyName("next")]
		public string Proximo { get; set; }

		[JsonPropertyName("prev")]
		public object Anterior { get; set; }
	}

	public class Episodio
	{
		[JsonPropertyName("id")]
		public int Id { get; set; }

		[JsonPropertyName("name")]
		public string Nome { get; set; }

		[JsonPropertyName("air_date")]
		public string Transmissao { get; set; }

		[JsonPropertyName("episode")]
		public string Episodios { get; set; }

		[JsonPropertyName("characters")]
		public List<string> Personagens { get; set; }

		[JsonPropertyName("url")]
		public string Url { get; set; }

		[JsonPropertyName("created")]
		public DateTime Criacao { get; set; }
	}

	public class RetornoApiEpisodio
	{
		[JsonPropertyName("info")]
		public Info Info { get; set; }

		[JsonPropertyName("results")]
		public List<Episodio> Episodios { get; set; }
	}
}
