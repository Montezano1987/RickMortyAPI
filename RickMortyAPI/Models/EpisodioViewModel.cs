﻿using System.Text.Json.Serialization;
using System;

namespace RickMortyAPI.Models
{
    public class EpisodioViewModel
    {

        public int Id { get; set; }
        public string Name { get; set; }
        public string AirDate { get; set; }
        public string Episode { get; set; }
        public List<string> Characters { get; set; }
        public string Url { get; set; }
        public DateTime Created { get; set; }
    }

    public class EpisodioResponse
    {
        public Info Info { get; set; }
        public List<EpisodioViewModel> Results { get; set; }
    }
}

