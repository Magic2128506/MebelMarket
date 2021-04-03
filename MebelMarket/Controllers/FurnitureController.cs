using MebelMarket.Infrastructure.Interfaces;
using MebelMarket.Infrastructure.Mapping;
using MebelMarket.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Linq;

namespace MebelMarket.Controllers
{
    public class FurnitureController : Controller
    {
        private readonly IFurnitureData _FurnitureData;

        public FurnitureController(IFurnitureData FurnitureData)
        {
            _FurnitureData = FurnitureData;
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

            return View(furniture.ToView());
        }

        public IActionResult Grid(int? id)
        {
            if (id <= 0 || id == null)
            {
                var LastFurnitures = _FurnitureData.GetLastFurnitures();

                return View(LastFurnitures.ToView());
            }

            var furnitures = _FurnitureData.GetByType(id.Value);

            return View(furnitures.ToView());
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

            decimal helper = (decimal)furnitures.Count() / (decimal)21;
            var page = Math.Ceiling(helper);

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
            var returnList = furnitures.ToList().GetRange(start, count);

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
    }
}
