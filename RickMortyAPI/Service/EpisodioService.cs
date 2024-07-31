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
			response.EnsureSuccessStatusCode();

			var jsonString = await response.Content.ReadAsStringAsync();
			var episodioResponse = JsonSerializer.Deserialize<RetornoApiEpisodioDTO>(jsonString);

			return episodioResponse.Episodios;

		}
	}
}
