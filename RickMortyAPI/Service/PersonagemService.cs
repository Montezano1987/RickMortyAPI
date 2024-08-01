using System.Text.Json;

namespace RickMortyAPI.Service
{
	public class PersonagemService
	{
		public async Task<List<Personagem>> BuscarPersonagens()
		{
			var httpClient = new HttpClient();
			var response = await httpClient.GetAsync("https://rickandmortyapi.com/api/character");

			var jsonString = await response.Content.ReadAsStringAsync();
			var personagemResponse = JsonSerializer.Deserialize<RetornoApiPersonagem>(jsonString);

			return personagemResponse.Results;

		}
	}
}
