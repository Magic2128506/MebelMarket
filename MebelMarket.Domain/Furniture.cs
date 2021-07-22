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

        /// <summary>
        /// Поставить на главную
        /// </summary>
        public bool IsNew { get; set; }

        /// <summary>
        /// Распродажа
        /// </summary>
        public bool IsFeatured { get; set; }

        public bool ForOffice { get; set; }

        public string Width { get; set; }
        public string Height { get; set; }
        public string Length { get; set; }

        /// <summary>
        /// Обивка
        /// </summary>
        public string Upholstery { get; set; }

        /// <summary>
        /// Наполнитель
        /// </summary>
        public string Filler { get; set; }

        /// <summary>
        /// Материал корпуса
        /// </summary>
        public string BodyMaterial { get; set; }

        /// <summary>
        /// Материал фасада
        /// </summary>
        public string FacadeMaterial { get; set; }
        public int? DiscountValue { get; set; }

        /// <summary>
        /// Шимо темный/светлый
        /// </summary>
        public bool Color1 { get; set; }

        /// <summary>
        /// Венге/дуб
        /// </summary>
        public bool Color2 { get; set; }

        /// <summary>
        /// Венге
        /// </summary>
        public bool Color3 { get; set; }

        /// <summary>
        /// Дуб сонома
        /// </summary>
        public bool Color4 { get; set; }

        /// <summary>
        /// Орех
        /// </summary>
        public bool Color5 { get; set; }

        /// <summary>
        /// Вишня
        /// </summary>
        public bool Color6 { get; set; }

        /// <summary>
        /// Бук
        /// </summary>
        public bool Color7 { get; set; }

        /// <summary>
        /// Дуб
        /// </summary>
        public bool Color8 { get; set; }

        /// <summary>
        /// Шимо светлый
        /// </summary>
        public bool Color9 { get; set; }

        /// <summary>
        /// Шимо темный
        /// </summary>
        public bool Color10 { get; set; }

        /// <summary>
        /// Выбеленное дерево
        /// </summary>
        public bool Color11 { get; set; }

        /// <summary>
        /// Дуб санома/белый
        /// </summary>
        public bool Color12 { get; set; }

        /// <summary>
        /// Дуб/розовый
        /// </summary>
        public bool Color13 { get; set; }

        /// <summary>
        /// Дуб/лайм
        /// </summary>
        public bool Color14 { get; set; }

        /// <summary>
        /// Дуб/синий
        /// </summary>
        public bool Color15 { get; set; }
    }
}
