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
			var localizacoes = await localizacaoService.BuscarLocalizacoes();

			List<LocalizacaoViewModel> viewModel = new List<LocalizacaoViewModel>();
			foreach (var localizacao in localizacoes)
			{
				viewModel.Add(new LocalizacaoViewModel
				{
					Name = localizacao.Name,
					Type = localizacao.Type,
					Dimension = localizacao.Dimension,
					Created = localizacao.Created,

				});
			}

			return View(viewModel);

		}
	}
}
