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

            if (newModel.TypeId != null)
            {
                model.TypeId = newModel.TypeId;
            }
        }

        public void Delete(int id)
        {
            var model = GetById(id);

            _db.Remove(model);
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
            .OrderByDescending(x => x.Id);

        public IEnumerable<Furniture> GetByType(int id)
            => _db.Furnitures
            .Where(x => x.TypeId == id)
            .OrderByDescending(x => x.Id);

        public Furniture GetById(int id)
            => _db.Furnitures.FirstOrDefault(x => x.Id == id);

        public IEnumerable<Furniture> GetFeaturedList()
            => _db.Furnitures
            .Where(x => x.IsFeatured)
            .OrderByDescending(x => x.Id)
            .Take(7);

        public IEnumerable<Furniture> GetLastFurnitures()
            => _db.Furnitures
            .OrderByDescending(x => x.Id)
            .Take(21);

        public IEnumerable<Furniture> GetNewList()
            => _db.Furnitures
            .Where(x => x.IsNew)
            .OrderByDescending(x => x.Id);

        public FurnitureType FindByName(string name)
            => _db.FurnitureTypes.FirstOrDefault(x => x.Name == name);

        public IEnumerable<Furniture> FindAnyByName(string name)
            => _db.Furnitures
            .Where(x => x.Name.Contains(name))
            .OrderByDescending(x => x.Id);

        public IEnumerable<Furniture> GetForOfficeFurnitures()
            => _db.Furnitures
            .Where(x => x.ForOffice)
            .OrderByDescending(x => x.Id);

        public IEnumerable<Furniture> GetForHomeFurnitures()
            => _db.Furnitures
            .Where(x => !x.ForOffice)
            .OrderByDescending(x => x.Id);

        public IEnumerable<FurnitureCategory> GetAllCategories()
            => _db.FurnitureCategories.ToList();

        public void CreateNewOrder(Order order)
        {
            if (order is null)
                throw new ArgumentNullException(nameof(order));

            _db.Add(order);
        }
    }
}
