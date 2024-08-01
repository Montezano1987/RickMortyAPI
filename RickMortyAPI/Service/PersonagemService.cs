using System.Text.Json;
using RickMortyAPI.Models;

namespace RickMortyAPI.Service
{
	public class PersonagemService
	{
		public async Task<List<Personagem>> BuscarPersonagens()
		{
			var httpClient = new HttpClient();
			var response = await httpClient.GetAsync("https://rickandmortyapi.com/api/character");

			var jsonString = await response.Content.ReadAsStringAsync();
			var personagemResponse = JsonSerializer.Deserialize<RetornoApiPersonagemDTO>(jsonString);

            List<Personagem> personagens = new List<Personagem>();
            foreach (var personagem in personagemResponse.PersonagensDTO)
            {
                personagens.Add(new Personagem
                {
                    Nome = personagem.Name,
					Especies = personagem.Species,
					Tipo = personagem.Type,
					Genero = personagem.Gender,
					Origem = personagem.Origin,
					Localizacao = personagem.Location,
					Imagem = personagem.Image,
					Criacao = personagem.Created,


					
                });
            }

            return personagens;

		}
	}
}
