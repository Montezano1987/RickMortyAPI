using System.Text.Json.Serialization;

namespace RickMortyAPI.ViewModel
{
	public class LocalizacaoViewModel
	{

		[JsonPropertyName("name")]
		public string Name { get; set; }

		[JsonPropertyName("type")]
		public string Type { get; set; }

		[JsonPropertyName("dimension")]
		public string Dimension { get; set; }

		[JsonPropertyName("created")]
		public DateTime Created { get; set; }
	}
}

