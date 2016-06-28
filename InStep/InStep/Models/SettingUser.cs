using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace InStep.Models
{
    public class SettingUser
    {
        public string Email { get; set; }

        [Required(ErrorMessage = "Поле имя должно быть заполнено")]
        [StringLength(50, MinimumLength = 2, ErrorMessage = "Имя должно быть не менее 2х символов")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Поле фамилия должно быть заполнено")]
        [StringLength(50, MinimumLength = 2, ErrorMessage = "Имя должно быть не менее 2х символов")]
        public string LastName { get; set; }
        public string SecondName { get; set; }
        public bool Sex { get; set; }

        [Required(ErrorMessage = "Поле телефон должно быть заполнено")]
        public string PhoneNumber { get; set; }
    }
}