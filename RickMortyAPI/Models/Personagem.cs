using System.Text.Json.Serialization;

namespace RickMortyAPI.Models
{
    public class Personagem
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Status { get; set; }
        public string Especies { get; set; }
        public string Tipo { get; set; }
        public string Genero { get; set; }
        public Origin Origem { get; set; }
        public Location Localizacao { get; set; }
        public string Imagem { get; set; }
        public List<string> Episodio { get; set; }
        public string Url { get; set; }
        public DateTime Criacao { get; set; }
    }
}
