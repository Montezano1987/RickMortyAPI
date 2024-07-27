using Microsoft.AspNetCore.Mvc;
using RickMortyAPI.Models;
using System.Text.Json;

namespace RickMortyAPI.Controllers
{
    public class EpisodioController : Controller
    {
        private readonly HttpClient _httpClient;

        public EpisodioController(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<IActionResult> Index()
        {
            var response = await _httpClient.GetAsync("https://rickandmortyapi.com/api/episode");
            response.EnsureSuccessStatusCode();

            var jsonString = await response.Content.ReadAsStringAsync();
            var episodioResponse = JsonSerializer.Deserialize<EpisodioViewModel>(jsonString, new JsonSerializerOptions { PropertyNamingPolicy = JsonNamingPolicy.CamelCase });

            return View(episodioResponse);
        }
    }
}
