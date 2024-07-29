using System.Text.Json.Serialization;

namespace RickMortyAPI.Models
{
    public class EpisodioViewModel
    {

        public int Id { get; set; }
        public string Name { get; set; }

		[JsonPropertyName("air_date")]
		public string AirDate { get; set; }

		public string Episode { get; set; }
        public List<string> Characters { get; set; }
        public string Url { get; set; }
        public DateTime Created { get; set; }
    }

    public class EpisodioResponse
    {
        public Info2 Info2 { get; set; }
        public List<EpisodioViewModel> Results { get; set; }
    }

	public class Info2
	{
		public int Count { get; set; }
		public int Pages { get; set; }
		public string Next { get; set; }
		public object Prev { get; set; }
	}
	public class Result
	{
		public int Id { get; set; }
		public string Name { get; set; }

		[JsonPropertyName("air_date")]
		public string AirDate { get; set; }

		public string Episode { get; set; }
		public List<string> Characters { get; set; }
		public string Url { get; set; }
		public DateTime Created { get; set; }
	}
}

