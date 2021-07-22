using MebelMarket.Infrastructure.Interfaces;
using MebelMarket.Infrastructure.Services.Notify;
using MebelMarket.Models;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Diagnostics;
using System.Threading.Tasks;

namespace MebelMarket.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IFurnitureData _FurnitureData;
        private readonly IWebHostEnvironment _environment;
        private readonly Notify _notify;

        public HomeController(ILogger<HomeController> logger, IFurnitureData FurnitureData, IWebHostEnvironment environment, Notify notify)
        {
            _logger = logger;
            _FurnitureData = FurnitureData;
            _environment = environment;
            _notify = notify;
        }

        public IActionResult Index()
        {
            var wwwroot = _environment.WebRootPath;
            ViewBag.wwwroot = wwwroot;

            return View();
        }

        public IActionResult Delivery()
        {
            return View();
        }

        public IActionResult Contacts(string success = null)
        {
            ViewBag.Success = success;

            return View();
        }

        public IActionResult AboutUs()
        {
            return View();
        }

        public IActionResult Payment()
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
            return RedirectPermanent(url);
        }

        public IActionResult SendEmail(ContactsUsViewModel cvm)
        {
            if (!ModelState.IsValid)
                return View(nameof(Contacts));

            var message = $"Поступил вопрос от клиента.\n\rИмя: {cvm.Name}\n\rТема: {cvm.Theme}\n\rEmail: {cvm.Email}\n\rСообщение: {cvm.Message}";

            var task = Task.Run(async () => { await _notify.SendMessageToTelegramAsync(message); });
            task.Wait();

            return Redirect("/Home/Contacts?success=1");
        }
    }
}
