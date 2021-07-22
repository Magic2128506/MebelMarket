using MebelMarket.Infrastructure.Interfaces;
using MebelMarket.Infrastructure.Mapping;
using MebelMarket.Infrastructure.Services.Notify;
using MebelMarket.Models;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Diagnostics;
using System.Linq;
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

        public IActionResult FindAny(string search, string filter, [FromQuery(Name = "page")] string pageId = null, [FromForm(Name = "sortOrder")] string sortOrder = null)
        {
            int pageIdValue = pageId == null ? 1 : int.Parse(pageId);

            var furnitures = _FurnitureData.FindAnyByName(search);

            if (filter == "forOffice")
            {
                furnitures = furnitures.Where(x => x.ForOffice);
            }
            else if (filter == "forHome")
            {
                furnitures = furnitures.Where(x => !x.ForOffice);
            }

            int allCount = furnitures.Count();
            int start = 15 * (pageIdValue - 1);
            int lastCount = allCount - start;
            int count = lastCount < 15 ? lastCount : 15;
            ViewBag.filter = filter == "forOffice"
            ? "forOffice"
            : filter == "forHome"
                ? "forHome"
                : null;

            if (count < 1)
            {
                return RedirectToAction("Grid", "Furniture");
            }

            if (sortOrder == "byPrice")
            {
                furnitures = furnitures.OrderBy(x => x.Price);
            }
            else if (sortOrder == "byPriceDesc")
            {
                furnitures = furnitures.OrderByDescending(x => x.Price);
            }

            decimal helper = (decimal)allCount / (decimal)15;
            var pagesCount = Math.Ceiling(helper);

            var returnList = furnitures.ToList().GetRange(start, count);

            ViewBag.usedFilter = "FindAny";
            ViewBag.usedFilterString = search;
            ViewBag.usedPage = pageIdValue;
            ViewBag.usedCategory = 0;
            ViewBag.pagesCount = pagesCount;
            ViewBag.allCount = allCount;
            ViewBag.SordOrder = sortOrder;

            return RedirectToAction("Grid", "Furniture", returnList.ToView());
        }

        public IActionResult SendEmail(ContactsUsViewModel cvm)
        {
            if (!ModelState.IsValid)
                return View(nameof(Contacts));
            string ip = HttpContext.Connection.RemoteIpAddress.ToString();
            var message = $"Поступил вопрос от клиента.\n\rИмя: {cvm.Name}\n\rТема: {cvm.Theme}\n\rEmail: {cvm.Email}\n\rСообщение: {cvm.Message}\n\rIP: {ip}";

            var task = Task.Run(async () => { await _notify.SendMessageToTelegramAsync(message); });
            task.Wait();

            return Redirect("/Home/Contacts?success=1");
        }
    }
}
