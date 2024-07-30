﻿using System.Text.Json;

namespace RickMortyAPI.Service
{
	public class PersonagemService
	{
		public async Task<List<ResultPersonagem>> BuscarPersonagens()
		{
			var httpClient = new HttpClient();
			var response = await httpClient.GetAsync("https://rickandmortyapi.com/api/character");
			response.EnsureSuccessStatusCode();

			var jsonString = await response.Content.ReadAsStringAsync();
			var personagemResponse = JsonSerializer.Deserialize<Personagem>(jsonString);

			return personagemResponse.Results;

		}
	}
}
