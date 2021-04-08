using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MebelMarket.Models
{
    public class ContactsUsViewModel
    {
        [Display(Name = "Ваше имя")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "Имя является обязательным")]
        [MinLength(2, ErrorMessage = "Проверьте корректность введенного имени")]
        public string Name { get; set; }

        [Display(Name = "Тема")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "Имя является обязательным")]
        [MinLength(2, ErrorMessage = "Проверьте корректность введенного имени")]
        public string Theme { get; set; }

        [DataType(DataType.EmailAddress)]
        [Display(Name = "Email")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "Емайл адрес является обязательным")]
        public string Email { get; set; }

        [Display(Name = "Ваше сообщение")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "Текст сообщения является обязательным для заполнения")]
        [MinLength(10, ErrorMessage = "Минимум 10 символов")]
        public string Message { get; set; }
    }
}
