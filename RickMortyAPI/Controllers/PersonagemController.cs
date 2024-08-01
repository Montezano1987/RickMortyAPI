using Microsoft.AspNetCore.Mvc;
using RickMortyAPI.Service;
using RickMortyAPI.ViewModel;

namespace RickMortyAPI.Controllers
{
    public class PersonagemController : Controller
	{

		public async Task<IActionResult> Index()
		{
			var personagemService = new PersonagemService();
			var personagens = await personagemService.BuscarPersonagens();

			List<PersonagemViewModel> viewModel = new List<PersonagemViewModel>();

			foreach (var personagem in personagens)
			{
				viewModel.Add(new PersonagemViewModel
				{
					Nome = personagem.Nome,
					Especie = personagem.Especies,
					Tipo = personagem.Tipo,
					Genero = personagem.Genero,
					Origem = personagem.Origem,
					Localizacao = personagem.Localizacao,
					Imagem = personagem.Imagem,
					Criado = personagem.Criado
				});
			}

			return View(viewModel);

		}
	}
}

