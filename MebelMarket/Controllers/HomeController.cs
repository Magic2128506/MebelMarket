using MebelMarket.Infrastructure.Interfaces;
using MebelMarket.Models;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Diagnostics;

namespace MebelMarket.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IFurnitureData _FurnitureData;
        private readonly IWebHostEnvironment _environment;

        public HomeController(ILogger<HomeController> logger, IFurnitureData FurnitureData, IWebHostEnvironment environment)
        {
            _logger = logger;
            _FurnitureData = FurnitureData;
            _environment = environment;
        }

        public IActionResult Index()
        {
            var wwwroot = _environment.WebRootPath;
            ViewBag.wwwroot = wwwroot;

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
