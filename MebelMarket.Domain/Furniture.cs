using System.ComponentModel.DataAnnotations.Schema;

namespace MebelMarket.Domain
{
    public class Furniture
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public int? TypeId { get; set; }

        [ForeignKey(nameof(TypeId))]
        public FurnitureType Type { get; set; }

        public string Description { get; set; }

        [Column(TypeName = "decimal(18,2)")]
        public decimal Price { get; set; }

        public bool IsNew { get; set; }

        public bool IsFeatured { get; set; }

        public bool ForOffice { get; set; }

        public string Width { get; set; }
        public string Height { get; set; }
        public string Length { get; set; }
        public string Upholstery { get; set; }
        public string Filler { get; set; }
        public string BodyMaterial { get; set; }
        public string FacadeMaterial { get; set; }
        public int? DiscountValue { get; set; }
    }
}
