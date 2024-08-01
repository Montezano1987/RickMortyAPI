using System.Text.Json.Serialization;

namespace RickMortyAPI.ViewModel
{
	public class EpisodioViewModel
	{
		public string Name { get; set; }

		[JsonPropertyName("air_date")]
		public string AirDate { get; set; }
		public string Episode { get; set; }
		public DateTime Created { get; set; }
	}
}
