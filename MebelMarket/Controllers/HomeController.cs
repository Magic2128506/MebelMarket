using MebelMarket.Infrastructure.Interfaces;
using MebelMarket.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Diagnostics;

namespace MebelMarket.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IFurnitureData _FurnitureData;

        public HomeController(ILogger<HomeController> logger, IFurnitureData FurnitureData)
        {
            _logger = logger;
            _FurnitureData = FurnitureData;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        public IActionResult FindAny(string search)
        {
            string url = $"/Furniture/Search?Search={search}";
            return Redirect(url);
        }
    }
}
