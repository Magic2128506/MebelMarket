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
        [Display(Name = "Поставить на главную")]
        public bool IsNew { get; set; }
        [Display(Name = "Распродажа")]
        public bool IsFeatured { get; set; }
        [Display(Name = "Офисная мебель")]
        public bool ForOffice { get; set; }

        [Display(Name = "Ширина")]
        public string Width { get; set; }

        [Display(Name = "Высота")]
        public string Height { get; set; }

        [Display(Name = "Длина")]
        public string Length { get; set; }

        [Display(Name = "Обивка")]
        public string Upholstery { get; set; }

        [Display(Name = "Наполнитель")]
        public string Filler { get; set; }

        [Display(Name = "Материал корпуса")]
        public string BodyMaterial { get; set; }

        [Display(Name = "Материал фасада")]
        public string FacadeMaterial { get; set; }

        [Display(Name = "Размер скидки в % (целое число)")]
        public int? DiscountValue { get; set; }
    }
}
