using MebelMarket.Domain;
using System.Collections.Generic;

namespace MebelMarket.Infrastructure.Interfaces
{
    public interface IFurnitureData
    {
        public void SaveChanges() { }
        public void Add(Furniture newFurniture) { }
        public void Edit(int id, Furniture newModel) { }
        public void Delete(int id) { }
        Furniture GetById(int id);
        IEnumerable<Furniture> FindAnyByName(string name);
        IEnumerable<Furniture> GetByCategory(int id);
        IEnumerable<Furniture> GetByType(int id);
        IEnumerable<FurnitureType> GetAllTypes();
        FurnitureType FindByName(string name);
        IEnumerable<Furniture> GetNewList();
        IEnumerable<Furniture> GetFeaturedList();
        IEnumerable<Furniture> GetLastFurnitures();
        IEnumerable<Furniture> GetForOfficeFurnitures();
        IEnumerable<Furniture> GetForHomeFurnitures();
        public IEnumerable<FurnitureCategory> GetAllCategories();
    }
}
