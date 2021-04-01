using MebelMarket.Domain;
using MebelMarket.Infrastructure.Interfaces;
using MebelMarket.SqlDataAccess;
using System;
using System.Collections.Generic;
using System.Linq;

namespace MebelMarket.Infrastructure.Services.InSQL
{
    public class SQLFurnitureData : IFurnitureData
    {
        private readonly MebelMarketContext _db;

        public SQLFurnitureData(MebelMarketContext db) => _db = db;

        public void Add(Furniture furniture)
        {
            if (furniture is null)
                throw new ArgumentNullException(nameof(furniture));

            _db.Add(furniture);
        }

        public void Edit(int id, Furniture newModel)
        {
            if (newModel is null)
                throw new ArgumentNullException(nameof(newModel));

            var model = GetById(newModel.Id);

            if (model is null)
                return;

            model.Name = newModel.Name;
            model.Description = newModel.Description;
            model.Price = newModel.Price;
            model.IsNew = newModel.IsNew;
            model.IsFeatured = newModel.IsFeatured;
            model.ForOffice = newModel.ForOffice;
        }

        public void SaveChanges() => _db.SaveChanges();

        public IEnumerable<FurnitureType> GetAllTypes()
        {
            IQueryable<FurnitureType> query = _db.FurnitureTypes;

            return query.AsEnumerable();
        }

        public IEnumerable<Furniture> GetByCategory(int id)
            => _db.Furnitures
            .Where(x => x.Type.CategoryId == id)
            .OrderByDescending(x => x.Id)
            .Take(21);

        public Furniture GetById(int id)
            => _db.Furnitures.FirstOrDefault(x => x.Id == id);

        public IEnumerable<Furniture> GetFeaturedList()
            => _db.Furnitures
            .Where(x => x.IsFeatured)
            .OrderByDescending(x => x.Id)
            .Take(7);

        public IEnumerable<Furniture> GetList(int categoryId)
            => _db.Furnitures
            .Where(x => x.Type.Category.Id == categoryId)
            .OrderByDescending(x => x.Id)
            .Take(21);

        public IEnumerable<string> GetFurnitureTypeNames()
            => _db.FurnitureTypes
            .Where(x => x.Name != null)
            .Select(x => x.Name)
            .ToList();

        public IEnumerable<Furniture> GetLastFurnitures()
            => _db.Furnitures
            .OrderByDescending(x => x.Id)
            .Take(21);

        public IEnumerable<Furniture> GetNewList()
            => _db.Furnitures
            .Where(x => x.IsNew)
            .OrderByDescending(x => x.Id)
            .Take(7);

        public IEnumerable<Furniture> GetNewByCategoryList(int categoryId)
            => _db.Furnitures
            .Where(x => x.IsNew && x.Type.Category.Id == categoryId)
            .OrderByDescending(x => x.Id)
            .Take(7);

        public FurnitureType FindByName(string name)
            => _db.FurnitureTypes.FirstOrDefault(x => x.Name == name);

        public IEnumerable<Furniture> FindAnyByName(string name)
            => _db.Furnitures
            .Where(x => x.Name.Contains(name))
            .OrderByDescending(x => x.Id)
            .Take(21);

        public IEnumerable<Furniture> GetForOfficeFurnitures()
            => _db.Furnitures
            .Where(x => x.ForOffice)
            .OrderByDescending(x => x.Id)
            .Take(21);

        public IEnumerable<Furniture> GetForHomeFurnitures()
            => _db.Furnitures
            .Where(x => !x.ForOffice)
            .OrderByDescending(x => x.Id)
            .Take(21);
    }
}
