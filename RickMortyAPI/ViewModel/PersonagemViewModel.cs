using System.Text.Json.Serialization;

namespace RickMortyAPI.ViewModel
{
	public class PersonagemViewModel
	{
		[JsonPropertyName("name")]
		public string Name { get; set; }

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

		[JsonPropertyName("created")]
		public DateTime Created { get; set; }
	}
}
