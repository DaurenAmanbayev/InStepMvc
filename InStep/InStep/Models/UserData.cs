using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using InStep.Helpers;
using InStep.Models.Interfaces;

namespace InStep.Models
{
    public class UserData : IUserData, IUserPrincipal
    {
        [Key]
        public int Id { get; set; }

        [Required, MinLength(2)]
        public string FirstName { get; set; }
        [Required, MinLength(2)]
        public string LastName { get; set; }
        public string SecondName { get; set; }
        public bool Sex { get; set; }
        [DateRange]
        public DateTime BirthDate { get; set; }

        public string PhoneNumber { get; set; }

        [Required]
        public string Email { get; set; }
        [Required]
        public byte[] Password { get; set; }



        public UserData() { }

        public UserData(RegisterUserData rud)
        {
            FirstName = rud.FirstName;
            LastName = rud.LastName;
            SecondName = rud.SecondName;
            Sex = rud.Sex;
            BirthDate = rud.BirthDate;
            PhoneNumber = rud.PhoneNumber;
            Email = rud.Email;
            Password = rud.Password.Encrypt();
        }
    }
}