using Microsoft.AspNetCore.Mvc;
using RickMortyAPI.Models;
using System.Text.Json;

namespace RickMortyAPI.Controllers
{
    public class LocalizacaoController : Controller
    {
        private readonly HttpClient _httpClient;

        public LocalizacaoController(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<IActionResult> Index()
        {
            var response = await _httpClient.GetAsync("https://rickandmortyapi.com/api/location");
            response.EnsureSuccessStatusCode();

            var jsonString = await response.Content.ReadAsStringAsync();
            var localizacaoResponse = JsonSerializer.Deserialize<LocalizacaoResponse>(jsonString, new JsonSerializerOptions { PropertyNamingPolicy = JsonNamingPolicy.CamelCase });

            return View(localizacaoResponse.Results);
        }
    }
}
