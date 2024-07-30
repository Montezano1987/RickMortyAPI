using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using RickMortyAPI.Models;
using RickMortyAPI.ViewModel;

namespace RickMortyAPI.Controllers
{
    public class HomeController : Controller
    {
               
        public IActionResult Index()
        {
            return View();
        }
    }
}
