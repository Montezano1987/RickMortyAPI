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

			foreach (var e in episodios)
			{
				viewModel.Add(new EpisodioViewModel
				{
					Name = e.Name,
					AirDate = e.AirDate,
					Episode = e.Episode,
					Created = e.Created
				});
			}

			return View(viewModel);

		}
	}
}

