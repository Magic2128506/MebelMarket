using System.ComponentModel.DataAnnotations;

namespace MebelMarket.Models
{
    public class OrderViewModel
    {
        public int ID { get; set; }

        [Display(Name = "Введите Ваше имя:")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "Имя является обязательным")]
        [MinLength(2, ErrorMessage = "Проверьте корректность введенного имени")]
        public string Name { get; set; }

        [DataType(DataType.PhoneNumber)]
        [Display(Name = "Введите Ваш номер телефона:")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "Номер телефона является обязательным")]
        [MinLength(10, ErrorMessage = "Проверьте корректность введенного номера")]
        public string Phone { get; set; }
        public string Description { get; set; }
    }
}