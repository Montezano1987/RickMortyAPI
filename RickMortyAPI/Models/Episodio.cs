using System.Text.Json.Serialization;

namespace RickMortyAPI.Models
{
    public class Episodio
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Transmissao { get; set; }
        public string Episodios { get; set; }
        public List<string> Personagens { get; set; }
        public string Url { get; set; }
        public DateTime Criacao { get; set; }
    }
}
