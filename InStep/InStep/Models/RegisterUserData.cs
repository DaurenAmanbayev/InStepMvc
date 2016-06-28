using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using InStep.Helpers;
using InStep.Models.Interfaces;

namespace InStep.Models
{
    public class RegisterUserData : IRegisterUserData
    {
        [Required(ErrorMessage="Поле имя должно быть заполнено")]      
        [StringLength(50,MinimumLength=2,ErrorMessage="Имя должно быть не менее 2х символов")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Поле фамилия должно быть заполнено")]
        [StringLength(50, MinimumLength = 2, ErrorMessage = "Имя должно быть не менее 2х символов")]
        public string LastName { get; set; }
        public string SecondName { get; set; }
        public bool Sex { get; set; }

        [DateRange]
        public DateTime BirthDate { get; set; }

        [Required(ErrorMessage = "Поле телефон должно быть заполнено")]
        public string PhoneNumber { get; set; }

        [Required(ErrorMessage = "Поле email должно быть заполнено"), MinLength(5)]
        [RegularExpression(@"[A-Za-z0-9._%+-]+@[A-Za-z0-9.-]+\.[A-Za-z]{2,4}", ErrorMessage = "Некорректный адрес")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Поле пароль должно быть заполнено")]
        [StringLength(50, MinimumLength = 5, ErrorMessage = "Пароль должен состоять более чем из 5 символов")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Required(ErrorMessage = "Поле повторить пароль должно быть заполнено")]
        [StringLength(50, MinimumLength = 5, ErrorMessage = "Пароль должен состоять более чем из 5 символов")]
        [DataType(DataType.Password)]
        [Compare("Password", ErrorMessage = "Пароли не совпадают")]
        public string ConfirmPassword { get; set; }   
    }
}