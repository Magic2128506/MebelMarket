using System.ComponentModel.DataAnnotations.Schema;

namespace MebelMarket.Domain
{
    public class FurnitureType
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public int? CategoryId { get; set; }

        [ForeignKey(nameof(CategoryId))]
        public FurnitureCategory Category { get; set; }
    }
}
