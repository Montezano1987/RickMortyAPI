using System.Text.Json.Serialization;

    public class Info2
    {
        [JsonPropertyName("count")]
        public int Count { get; set; }

        [JsonPropertyName("pages")]
        public int Pages { get; set; }

        [JsonPropertyName("next")]
        public string Next { get; set; }

        [JsonPropertyName("prev")]
        public object Prev { get; set; }
    }

    public class EpisodiosDTO
    {
        [JsonPropertyName("id")]
        public int Id { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("air_date")]
        public string AirDate { get; set; }

        [JsonPropertyName("episode")]
        public string Episode { get; set; }

        [JsonPropertyName("characters")]
        public List<string> Characters { get; set; }

        [JsonPropertyName("url")]
        public string Url { get; set; }

        [JsonPropertyName("created")]
        public DateTime Created { get; set; }
    }

    public class RetornoApiEpisodioDTO
    {
        [JsonPropertyName("info")]
        public Info Info { get; set; }

        [JsonPropertyName("results")]
        public List<EpisodiosDTO> EpisodiosDTO { get; set; }
    }
