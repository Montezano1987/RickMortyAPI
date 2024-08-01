using Microsoft.AspNetCore.Mvc;
using RickMortyAPI.Service;
using RickMortyAPI.ViewModel;

namespace RickMortyAPI.Controllers
{
    public class EpisodioController : Controller
	{

		public async Task<IActionResult> Index()
		{
			var episodioService = new EpisodioService();
			var episodios = await episodioService.BuscarEpisodios();

			List<EpisodioViewModel> viewModel = new List<EpisodioViewModel>();

			foreach (var episodio in episodios)
			{
				viewModel.Add(new EpisodioViewModel
				{
					Nome = episodio.Nome,
					Transmissao = episodio.Transmissao,
					Episodio = episodio.Episodios,
					Criacao = episodio.Criacao,
                });
			}

			return View(viewModel);

		}
	}
}

