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
            ForOffice = f.ForOffice,
            Width = f.Width,
            Height = f.Height,
            Length = f.Length,
            Upholstery = f.Upholstery,
            Filler = f.Filler,
            BodyMaterial = f.BodyMaterial,
            FacadeMaterial = f.FacadeMaterial,
            DiscountValue = f.DiscountValue
        };

        public static IEnumerable<FurnitureViewModel> ToView(this IEnumerable<Furniture> f) => f.Select(ToView);

        public static Furniture FromView(this FurnitureViewModel fvm) => new Furniture
        {
            Id = fvm.Id,
            Name = fvm.Name,
            Type = fvm.Type,
            Price = fvm.Price,
            Description = fvm.Description,
            IsFeatured = fvm.IsFeatured,
            IsNew = fvm.IsNew,
            ForOffice = fvm.ForOffice,
            Width = fvm.Width,
            Height = fvm.Height,
            Length = fvm.Length,
            Upholstery = fvm.Upholstery,
            Filler = fvm.Filler,
            BodyMaterial = fvm.BodyMaterial,
            FacadeMaterial = fvm.FacadeMaterial,
            DiscountValue = fvm.DiscountValue
        };
    }
}
