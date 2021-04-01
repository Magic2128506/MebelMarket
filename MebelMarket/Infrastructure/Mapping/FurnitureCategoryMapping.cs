using MebelMarket.Domain;
using MebelMarket.Models;
using System.Collections.Generic;
using System.Linq;

namespace MebelMarket.Infrastructure.Mapping
{
    public static class FurnitureCategoryMapping
    {
        public static FurnitureCategoryViewModel ToView(this FurnitureCategory type) => new FurnitureCategoryViewModel
        {
            Id = type.Id,
            Name = type.Name
        };

        public static IEnumerable<FurnitureCategoryViewModel> ToView(this IEnumerable<FurnitureCategory> p) => p.Select(ToView);
    }
}
