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

			foreach (var p in personagens)
			{
				viewModel.Add(new PersonagemViewModel
				{
					Name = p.Name,
					Species = p.Species,
					Type = p.Type,
					Gender = p.Gender,
					Origin = p.Origin,
					Location = p.Location,
					Image = p.Image,
					Created = p.Created
				});
			}

			return View(viewModel);

		}
	}
}

