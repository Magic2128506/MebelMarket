using MebelMarket.Domain;
using System.Collections.Generic;

namespace MebelMarket.Infrastructure.Interfaces
{
    public interface IFurnitureData
    {
        public void SaveChanges() { }
        public void Add(Furniture newFurniture) { }
        Furniture GetById(int id);
        IEnumerable<Furniture> FindAnyByName(string name);
        IEnumerable<Furniture> GetByCategory(int id);
        IEnumerable<FurnitureType> GetAllTypes();
        FurnitureType FindByName(string name);
        IEnumerable<Furniture> GetNewList();
        IEnumerable<Furniture> GetFeaturedList();
        IEnumerable<Furniture> GetList(int categoryId);
        IEnumerable<Furniture> GetLastFurnitures();
        IEnumerable<string> GetFurnitureTypeNames();
        IEnumerable<Furniture> GetForOfficeFurnitures();
        IEnumerable<Furniture> GetForHomeFurnitures();
    }
}
