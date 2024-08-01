using System.Text.Json.Serialization;

namespace RickMortyAPI.ViewModel
{
	public class EpisodioViewModel
	{
		public string Nome { get; set; }

		[JsonPropertyName("air_date")]
		public string Transmissao { get; set; }
		public string Episodio { get; set; }
		public DateTime Criacao { get; set; }
	}
}
