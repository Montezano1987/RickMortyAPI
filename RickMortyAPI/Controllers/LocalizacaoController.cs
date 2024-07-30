using Microsoft.AspNetCore.Mvc;
using RickMortyAPI.ViewModel;
using RickMortyAPI.Models;
using RickMortyAPI.Service;

namespace RickMortyAPI.Controllers
{
	public class LocalizacaoController : Controller
	{
		public async Task<IActionResult> Index()
		{
			var localizacaoService = new LocalizacaoService();
			var localizacao = await localizacaoService.BuscarLocalizacoes();

			List<LocalizacaoViewModel> viewModel = new List<LocalizacaoViewModel>();
			foreach (var l in localizacao)
			{
				viewModel.Add(new LocalizacaoViewModel
				{
					Name = l.Name,
					Type = l.Type,
					Dimension = l.Dimension,
					Created = l.Created,

				});
			}

			return View(viewModel);

		}
	}
}
