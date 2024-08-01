using System.Text.Json.Serialization;

namespace RickMortyAPI.Models
{
    public class Localizacao
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Tipo { get; set; }
        public string Dimensao { get; set; }
        public List<string> Residentes { get; set; }
        public string Url { get; set; }
        public DateTime Criacao { get; set; }

    }
}
