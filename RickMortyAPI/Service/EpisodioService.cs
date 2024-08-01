using System.Text.Json;
using RickMortyAPI.Models;

namespace RickMortyAPI.Service
{
    public class EpisodioService
	{
		public async Task<List<Episodio>> BuscarEpisodios()
		{
			var httpClient = new HttpClient();
			var response = await httpClient.GetAsync("https://rickandmortyapi.com/api/episode");

			var jsonString = await response.Content.ReadAsStringAsync();
			var episodioResponse = JsonSerializer.Deserialize<RetornoApiEpisodioDTO>(jsonString);

            List<Episodio> episodios = new List<Episodio>();
            foreach (var episodio in episodioResponse.EpisodiosDTO)
            {
                episodios.Add(new Episodio
                {
                    Nome = episodio.Name,
                    Criacao = episodio.Created,
                    Episodios = episodio.Episode,
                    Transmissao = episodio.AirDate,

                });
            }

            return episodios;

		}
	}
}
