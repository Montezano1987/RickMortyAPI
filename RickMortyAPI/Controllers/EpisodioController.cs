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
					Name = episodio.Name,
					AirDate = episodio.AirDate,
					Episode = episodio.Episode,
					Created = episodio.Created
				});
			}

			return View(viewModel);

		}
	}
}

