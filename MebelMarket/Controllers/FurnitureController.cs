using MebelMarket.Infrastructure.Interfaces;
using MebelMarket.Infrastructure.Mapping;
using MebelMarket.Models;
using Microsoft.AspNetCore.Mvc;
using System;

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

        public IActionResult Search([FromQuery(Name = "Search")] string search)
        {
            return FindAny(search);
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

            return Redirect($"Index/{model.Id}");
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
        public IActionResult Edit(FurnitureViewModel furnitureViewModel)
        {
            if (furnitureViewModel is null)
                throw new ArgumentNullException(nameof(furnitureViewModel));

            if (!ModelState.IsValid)
                return View(furnitureViewModel);

            var id = furnitureViewModel.Id;
            if (id == 0)
                _FurnitureData.Add(furnitureViewModel.FromView());
            else
                _FurnitureData.Edit(id, furnitureViewModel.FromView());

            _FurnitureData.SaveChanges();

            return View(furnitureViewModel);
        }
    }
}
