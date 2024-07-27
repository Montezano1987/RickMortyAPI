using System.Net.Http;
using System.Text.Json;
using RickMortyAPI.Controllers;
using Microsoft.AspNetCore.Mvc;
using RickMortyAPI.Models;

public class PersonagemController : Controller
{
    private readonly HttpClient _httpClient;

    public PersonagemController(HttpClient httpClient)
    {
        _httpClient = httpClient;
    }

    public async Task<IActionResult> Index()
    {
        var response = await _httpClient.GetAsync("https://rickandmortyapi.com/api/character");
        response.EnsureSuccessStatusCode();

        var jsonString = await response.Content.ReadAsStringAsync();
        var personagemResponse = JsonSerializer.Deserialize<PersonagemResponse>(jsonString, new JsonSerializerOptions { PropertyNamingPolicy = JsonNamingPolicy.CamelCase });

        return View(personagemResponse.Results);
    }
}
