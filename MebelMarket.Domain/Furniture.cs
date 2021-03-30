using System.ComponentModel.DataAnnotations.Schema;

namespace MebelMarket.Domain
{
    public class Furniture
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public FurnitureType Type { get; set; }
        public string Description { get; set; }
        [Column(TypeName = "decimal(18,2)")]
        public decimal Price { get; set; }
        public bool IsNew { get; set; }
        public bool IsFeatured { get; set; }
    }
}
