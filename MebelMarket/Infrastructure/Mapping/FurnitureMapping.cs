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
            DiscountValue = f.DiscountValue,
            Color1 = f.Color1,
            Color2 = f.Color2,
            Color3 = f.Color3,
            Color4 = f.Color4,
            Color5 = f.Color5,
            Color6 = f.Color6,
            Color7 = f.Color7,
            Color8 = f.Color8,
            Color9 = f.Color9,
            Color10 = f.Color10,
            Color11 = f.Color11,
            Color12 = f.Color12,
            Color13 = f.Color13,
            Color14 = f.Color14,
            Color15 = f.Color15
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
            DiscountValue = fvm.DiscountValue,
            Color1 = fvm.Color1,
            Color2 = fvm.Color2,
            Color3 = fvm.Color3,
            Color4 = fvm.Color4,
            Color5 = fvm.Color5,
            Color6 = fvm.Color6,
            Color7 = fvm.Color7,
            Color8 = fvm.Color8,
            Color9 = fvm.Color9,
            Color10 = fvm.Color10,
            Color11 = fvm.Color11,
            Color12 = fvm.Color12,
            Color13 = fvm.Color13,
            Color14 = fvm.Color14,
            Color15 = fvm.Color15
        };
    }
}
