using MebelMarket.Infrastructure.Interfaces;
using MebelMarket.Infrastructure.Mapping;
using Microsoft.AspNetCore.Http;
using MebelMarket.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Linq;
using Microsoft.AspNetCore.Hosting;
using MebelMarket.Infrastructure.Services.Notify;

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

        public IActionResult Index(int? id)
        {
            if (id == null)
                return View(nameof(Grid));

            if (id < 0)
                return BadRequest();

            if (id == 0)
            {
                var lastFurnitures = _FurnitureData.GetLastFurnitures();

                return View(lastFurnitures.ToView());
            }

            var furniture = _FurnitureData.GetById(id.Value);

            var wwwroot = _environment.WebRootPath;
            ViewBag.wwwroot = wwwroot;

            return View(furniture.ToView());
        }

        public IActionResult Grid(int? id, [FromQuery(Name = "page")] string pageId)
        {
            if (id <= 0 || id == null)
            {
                var LastFurnitures = _FurnitureData.GetLastFurnitures();

                return View(LastFurnitures.ToView());
            }

            int pageIdValue = pageId == null ? 1 : int.Parse(pageId);
            int categoryId = 0;
            var furnitures = _FurnitureData.GetByType(id.Value);
            int start = 21 * (pageIdValue - 1);
            int lastCount = furnitures.Count() - start;
            int count = lastCount < 21 ? lastCount : 21;

            decimal helper = (decimal)furnitures.Count() / (decimal)21;
            var pagesCount = Math.Ceiling(helper);

            if (count < 1)
            {
                string url = $"/Furniture/Grid/{id.Value}";

                return Redirect(url);
            }

            var returnList = furnitures.ToList().GetRange(start, count);

            ViewBag.usedFilter = "Grid";
            ViewBag.usedPage = pageIdValue;
            ViewBag.usedCategory = categoryId;
            ViewBag.pagesCount = pagesCount;

            return View(returnList.ToView());
        }

        public IActionResult Search([FromQuery(Name = "Search")] string search)
        {
            return FindAny(search);
        }

        public IActionResult FindAny(string search)
        {
            var furnitures = _FurnitureData.FindAnyByName(search);

            return View(nameof(Grid), furnitures.ToView());
        }
        public IActionResult GridByCategory(int id)
        {
            var furnitures = _FurnitureData.GetByCategory(id);

            if (furnitures is null)
                return View(nameof(Grid));

            string url = $"/Furniture/ViewPageByCategory?page=1&categoryId={id}";

            return Redirect(url);
        }

        public IActionResult ViewPageByCategory([FromQuery(Name = "page")] string id, [FromQuery(Name = "categoryId")] string catId)
        {
            int pageId = int.Parse(id);
            int categoryId = int.Parse(catId);
            var furnitures = _FurnitureData.GetByCategory(categoryId);
            int start = 21 * (pageId - 1);
            int lastCount = furnitures.Count() - start;
            int count = lastCount < 21 ? lastCount : 21;

            decimal helper = (decimal)furnitures.Count() / (decimal)21;
            var pagesCount = Math.Ceiling(helper);

            if (count < 1)
            {
                string url = $"/Furniture/ViewPageByCategory?page=1&categoryId=1";

                return Redirect(url);
            }

            var returnList = furnitures.ToList().GetRange(start, count);

            ViewBag.usedFilter = "ViewPageByCategory";
            ViewBag.usedPage = pageId;
            ViewBag.usedCategory = catId;
            ViewBag.pagesCount = pagesCount;

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

        public IActionResult ViewForOffice()
        {
            var furnitures = _FurnitureData.GetForOfficeFurnitures();

            return View(nameof(Grid), furnitures.ToView());
        }

        public IActionResult ViewForHome()
        {
            var furnitures = _FurnitureData.GetForHomeFurnitures();

            return View(nameof(Grid), furnitures.ToView());
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

        public IActionResult SendEmail()
        {
            _notify.SendEmail("timur_nasibullin@mail.ru", "Hello");

            return Redirect("Grid/0");
        }
    }
}
