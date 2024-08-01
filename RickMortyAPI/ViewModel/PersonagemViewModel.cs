using System.Text.Json.Serialization;

namespace RickMortyAPI.ViewModel
{
	public class PersonagemViewModel
	{
		[JsonPropertyName("name")]
		public string Nome { get; set; }

		[JsonPropertyName("species")]
		public string Especie { get; set; }

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

		[JsonPropertyName("created")]
		public DateTime Criado { get; set; }
	}
}
