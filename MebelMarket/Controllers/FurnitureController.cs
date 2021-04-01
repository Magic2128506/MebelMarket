using MebelMarket.Domain;
using MebelMarket.Infrastructure.Interfaces;
using MebelMarket.Infrastructure.Mapping;
using MebelMarket.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

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
                return View("Grid");

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

            var furnitures = _FurnitureData.GetByCategory(id.Value);

            return View(furnitures.ToView());
        }

        public IActionResult Search(string search)
        {
            var furnitures = _FurnitureData.FindAnyByName(search);

            return View("Grid", furnitures.ToView());
        }

        public IActionResult FindAny(string search)
        {
            var furnitures = _FurnitureData.FindAnyByName(search);

            return View("Grid", furnitures.ToView());
        }
        public IActionResult GridByCategory(int id)
        {
            var furnitures = _FurnitureData.GetByCategory(id);

            if (furnitures is null)
                return View("Grid");

            return View("Grid", furnitures.ToView());
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

            return View(model.ToView());
        }

        public IActionResult ViewForOffice()
        {
            var furnitures = _FurnitureData.GetForOfficeFurnitures();

            return View("Grid", furnitures.ToView());
        }

        public IActionResult ViewForHome()
        {
            var furnitures = _FurnitureData.GetForHomeFurnitures();

            return View("Grid", furnitures.ToView());
        }
    }
}
