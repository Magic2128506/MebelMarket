using MebelMarket.Infrastructure.Interfaces;
using MebelMarket.Infrastructure.Mapping;
using Microsoft.AspNetCore.Http;
using MebelMarket.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Linq;
using Microsoft.AspNetCore.Hosting;
using MebelMarket.Infrastructure.Services.Notify;
using System.Threading.Tasks;

namespace MebelMarket.Controllers
{
    public class FurnitureController : Controller
    {
        private readonly IFurnitureData _FurnitureData;
        private readonly IWebHostEnvironment _environment;
        private readonly Notify _notify;

        public FurnitureController(IFurnitureData FurnitureData, IWebHostEnvironment environment, Notify notify)
        {
            _FurnitureData = FurnitureData;
            _environment = environment;
            _notify = notify;
        }

        public IActionResult Index(int? id, [FromQuery(Name = "filter")] string filter = null)
        {
            if (id == null)
                return View(nameof(Grid));

            if (id < 0)
                return BadRequest();

            if (id == 0)
            {
                var lastFurnitures = _FurnitureData.GetLastFurnitures().Take(21);

                return View(lastFurnitures.ToView());
            }

            var furniture = _FurnitureData.GetById(id.Value);

            var wwwroot = _environment.WebRootPath;
            ViewBag.wwwroot = wwwroot;
            ViewBag.filter = filter == "forOffice"
                ? "forOffice"
                : filter == "forHome"
                    ? "forHome"
                    : null;

            return View(furniture.ToView());
        }

        public IActionResult Grid(int? id, 
            [FromQuery(Name = "page")] string pageId, 
            [FromForm(Name = "sortOrder")] string sortOrder = null, 
            [FromQuery(Name = "filter")] string filter = null)
        {
            ViewBag.filter = filter == "forOffice"
            ? "forOffice"
            : filter == "forHome"
                ? "forHome"
                : null;
            int pageIdValue = pageId == null ? 1 : int.Parse(pageId);
            int categoryId = 0;

            var furnitures = id <= 0 || id == null
                ? _FurnitureData.GetLastFurnitures()
                : _FurnitureData.GetByType(id.Value);

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

            decimal helper = (decimal)allCount / (decimal)15;
            var pagesCount = Math.Ceiling(helper);

            if (count < 1)
            {
                return View(nameof(Grid));
            }

            if (sortOrder == "byPrice")
            {
                furnitures = furnitures.OrderBy(x => x.Price);
            }
            else if (sortOrder == "byPriceDesc")
            {
                furnitures = furnitures.OrderByDescending(x => x.Price);
            }

            var returnList = furnitures.ToList().GetRange(start, count);

            ViewBag.usedFilter = "Grid";
            ViewBag.usedPage = pageIdValue;
            ViewBag.usedCategory = categoryId;
            ViewBag.pagesCount = pagesCount;
            ViewBag.allCount = allCount;
            ViewBag.SordOrder = sortOrder;

            return View(returnList.ToView());
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
                return View(nameof(Grid));
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

            return View(nameof(Grid), returnList.ToView());
        }
        public IActionResult GridByCategory(int id, [FromQuery(Name = "filter")] string filter = null)
        {
            var furnitures = _FurnitureData.GetByCategory(id);

            if (filter == "forOffice")
            {
                furnitures = furnitures.Where(x => x.ForOffice);
            }
            else if (filter == "forHome")
            {
                furnitures = furnitures.Where(x => !x.ForOffice);
            }

            ViewBag.filter = filter == "forOffice"
                ? "forOffice"
                : filter == "forHome"
                    ? "forHome"
                    : null;

            if (furnitures is null)
                return View(nameof(Grid));

            string url = $"/Furniture/ViewPageByCategory?page=1&categoryId={id}";
            if (filter != null)
                url += $"&filter={filter}";

            return Redirect(url);
        }

        public IActionResult ViewPageByCategory([FromQuery(Name = "page")] string id, [FromQuery(Name = "categoryId")] string catId, [FromForm(Name = "sortOrder")] string sortOrder = null, [FromQuery(Name = "filter")] string filter = null)
        {
            int pageId = id == null ? 1 : int.Parse(id);
            int categoryId = int.Parse(catId);
            var furnitures = _FurnitureData.GetByCategory(categoryId);

            if (filter == "forOffice")
            {
                furnitures = furnitures.Where(x => x.ForOffice);
            }
            else if (filter == "forHome")
            {
                furnitures = furnitures.Where(x => !x.ForOffice);
            }

            int start = 15 * (pageId - 1);
            int allCount = furnitures.Count();
            int lastCount = allCount - start;
            int count = lastCount < 15 ? lastCount : 15;

            decimal helper = (decimal)allCount / (decimal)15;
            var pagesCount = Math.Ceiling(helper);
            ViewBag.filter = filter == "forOffice"
            ? "forOffice"
            : filter == "forHome"
                ? "forHome"
                : null;

            if (count < 1)
            {
                return View(nameof(Grid));
            }

            if (sortOrder == "byPrice")
            {
                furnitures = furnitures.OrderBy(x => x.Price);
            }
            else if (sortOrder == "byPriceDesc")
            {
                furnitures = furnitures.OrderByDescending(x => x.Price);
            }

            var returnList = furnitures.ToList().GetRange(start, count);

            ViewBag.usedFilter = "ViewPageByCategory";
            ViewBag.usedPage = pageId;
            ViewBag.usedCategory = catId;
            ViewBag.pagesCount = pagesCount;
            ViewBag.allCount = allCount;
            ViewBag.SordOrder = sortOrder;

            return View($"Grid", returnList.ToView());
        }

        public IActionResult Create() => View(new FurnitureViewModel());

        [HttpPost, ValidateAntiForgeryToken]
        public IActionResult Create(FurnitureViewModel viewModel, string type)
        {
            if (!ModelState.IsValid)
                return View(viewModel);

            var model = viewModel.FromView();
            model.TypeId = _FurnitureData.FindByName(type).Id;

            _FurnitureData.Add(model);
            _FurnitureData.SaveChanges();

            return Redirect($"Index/{model.Id}");
        }

        public IActionResult Edit(int? Id)
        {
            if (Id is null || Id < 0)
                return View(new FurnitureViewModel());

            var furniture = _FurnitureData.GetById((int)Id);

            if (furniture is null)
                return NotFound();

            return View(furniture.ToView());
        }

        [HttpPost, ValidateAntiForgeryToken]
        public IActionResult Edit(FurnitureViewModel furnitureViewModel, string type)
        {
            if (furnitureViewModel is null)
                throw new ArgumentNullException(nameof(furnitureViewModel));

            if (!ModelState.IsValid)
                return View(furnitureViewModel);

            var model = furnitureViewModel.FromView();

            var id = furnitureViewModel.Id;
            if (id == 0)
                _FurnitureData.Add(model);
            else
            {
                if (type != null)
                {
                    var typeId = _FurnitureData.FindByName(type).Id;
                    var modelFromDB = _FurnitureData.GetById(id);

                    if (model.TypeId != modelFromDB.TypeId)
                        model.TypeId = typeId;
                }

                _FurnitureData.Edit(id, model);
            }

            _FurnitureData.SaveChanges();

            return View(furnitureViewModel);
        }

        public IActionResult DeleteItem(int? Id)
        {
            if (Id is null || Id < 0)
                return View(new FurnitureViewModel());

            var furniture = _FurnitureData.GetById((int)Id);

            if (furniture is null)
                return NotFound();

            return View(furniture.ToView());
        }

        [HttpPost, ValidateAntiForgeryToken]
        public IActionResult DeleteConfirmed(int id)
        {
            _FurnitureData.Delete(id);
            _FurnitureData.SaveChanges();

            return View(nameof(Grid));
        }

        public IActionResult SendEmail(OrderViewModel orderVM)
        {
            if (!ModelState.IsValid)
                return View();

            var order = orderVM.FromView();
            _FurnitureData.CreateNewOrder(order);
            _FurnitureData.SaveChanges();

            var info = order.Description.Split(';');
            string ip = HttpContext.Connection.RemoteIpAddress.ToString();
            var message = $"ID - {info[0]}, Название - {info[1]}, Цена без скидки - {info[2]}, Скидка - {info[3]}%";
            message = $"Поступил новый заказ от клиента.\n\rИмя: {order.Name}\n\rТелефон: {order.Phone}\n\rТовар: {message}\n\rIP: {ip}";
            //_notify.SendEmail("timur_nasibullin@mail.ru", message);
            var task = Task.Run(async () => { await _notify.SendMessageToTelegramAsync(message); });
            task.Wait();
            var furniture = _FurnitureData.GetById(int.Parse(info[0]));

            return View($"OrderConfirm", furniture.ToView());
        }

        public IActionResult OrderConfirm(FurnitureViewModel furnitureViewModel)
        {
            return View();
        }

        public IActionResult Categories([FromQuery(Name = "filter")] string filter = null)
        {
            ViewBag.filter = filter == "forOffice"
                ? "forOffice"
                : filter == "forHome"
                    ? "forHome"
                    : null;

            return View();
        }
    }
}
