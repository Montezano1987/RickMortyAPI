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
					Name = personagem.Name,
					Species = personagem.Species,
					Type = personagem.Type,
					Gender = personagem.Gender,
					Origin = personagem.Origin,
					Location = personagem.Location,
					Image = personagem.Image,
					Created = personagem.Created
				});
			}

			return View(viewModel);

		}
	}
}

