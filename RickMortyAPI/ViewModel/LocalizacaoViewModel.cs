using System.Text.Json.Serialization;

namespace RickMortyAPI.ViewModel
{
	public class LocalizacaoViewModel
	{

		[JsonPropertyName("name")]
		public string Nome { get; set; }

		[JsonPropertyName("type")]
		public string Tipo { get; set; }

		[JsonPropertyName("dimension")]
		public string Dimensao { get; set; }

		[JsonPropertyName("created")]
		public DateTime Criado { get; set; }
	}
}

