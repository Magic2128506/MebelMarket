using MebelMarket.Domain;
using MebelMarket.Models;
using System.Collections.Generic;
using System.Linq;

namespace MebelMarket.Infrastructure.Mapping
{
    public static class FurnitureTypeMapping
    {
        public static FurnitureTypeViewModel ToView(this FurnitureType type) => new FurnitureTypeViewModel
        {
            Id = type.Id,
            Name = type.Name,
            Category = type.CategoryId.Value
        };

        public static IEnumerable<FurnitureTypeViewModel> ToView(this IEnumerable<FurnitureType> p) => p.Select(ToView);
    }
}
