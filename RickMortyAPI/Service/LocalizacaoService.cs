using RickMortyAPI.Models;
using RickMortyAPI.ViewModel;
using System.Text.Json;

namespace RickMortyAPI.Service
{
    public class LocalizacaoService
    {
        public async Task<List<Localizacao>> BuscarLocalizacoes()
        {
            var httpClient = new HttpClient();
            var response = await httpClient.GetAsync("https://rickandmortyapi.com/api/location");

			var jsonString = await response.Content.ReadAsStringAsync();
            var localizacaoResponse = JsonSerializer.Deserialize<RetornoApiLocalizacaoDTO>(jsonString);

            List<Localizacao> localizacoes = new List<Localizacao>();
            foreach (var localizacao in localizacaoResponse.LocalizacoesDTO)
            {
                localizacoes.Add(new Localizacao
                {
                    Nome = localizacao.Name,
                    Tipo = localizacao.Type,
                    Dimensao = localizacao.Dimension,
                    Criacao = localizacao.Created,

                });
            }

            return localizacoes;
		}

    }
}
