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
			var episodioResponse = JsonSerializer.Deserialize<RetornoApiEpisodio>(jsonString);

			return episodioResponse.Episodios;

		}
	}
}
