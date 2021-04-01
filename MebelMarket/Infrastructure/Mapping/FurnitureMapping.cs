using MebelMarket.Domain;
using MebelMarket.Models;
using System.Collections.Generic;
using System.Linq;

namespace MebelMarket.Infrastructure.Mapping
{
    public static class FurnitureMapping
    {
        public static FurnitureViewModel ToView(this Furniture f) => new FurnitureViewModel
        {
            Id = f.Id,
            Name = f.Name,
            Type = f.Type,
            Price = f.Price,
            Description = f.Description,
            IsFeatured = f.IsFeatured,
            IsNew = f.IsNew,
            ForOffice = f.ForOffice
        };

        public static IEnumerable<FurnitureViewModel> ToView(this IEnumerable<Furniture> f) => f.Select(ToView);

        public static Furniture FromView(this FurnitureViewModel vwm) => new Furniture
        {
            Id = vwm.Id,
            Name = vwm.Name,
            Type = vwm.Type,
            Price = vwm.Price,
            Description = vwm.Description,
            IsFeatured = vwm.IsFeatured,
            IsNew = vwm.IsNew,
            ForOffice = vwm.ForOffice
        };
    }
}
