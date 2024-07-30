using RickMortyAPI.Models;
using System.Text.Json;

namespace RickMortyAPI.Service
{
    public class LocalizacaoService
    {
        public async Task<List<ResultLocalizacao>> BuscarLocalizacoes()
        {
            var httpClient = new HttpClient();
            var response = await httpClient.GetAsync("https://rickandmortyapi.com/api/location");
			response.EnsureSuccessStatusCode();

			var jsonString = await response.Content.ReadAsStringAsync();
            var localizacaoResponse = JsonSerializer.Deserialize<Localizacao>(jsonString);

			return localizacaoResponse.Results;
		}

    }
}
