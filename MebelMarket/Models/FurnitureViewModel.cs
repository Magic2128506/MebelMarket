using MebelMarket.Domain;
using System.ComponentModel.DataAnnotations;

namespace MebelMarket.Models
{
    public class FurnitureViewModel
    {
        public int Id { get; set; }
        [Required]
        [Display(Name = "Название")]
        public string Name { get; set; }

        [Display(Name = "Тип продукции")]
        public FurnitureType Type { get; set; }

        [Display(Name = "Описание")]
        public string Description { get; set; }
        [Required]
        [Display(Name = "Цена")]
        public decimal Price { get; set; }
        public bool IsNew { get; set; }
        public bool IsFeatured { get; set; }
        [Display(Name = "Офисная мебель")]
        public bool ForOffice { get; set; }
    }
}
