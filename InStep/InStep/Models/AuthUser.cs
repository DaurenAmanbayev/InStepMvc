using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using InStep.Helpers;

namespace InStep.Models
{
    public class AuthUser
    {
        [Required]
        [RegularExpression(@"[A-Za-z0-9._%+-]+@[A-Za-z0-9.-]+\.[A-Za-z]{2,4}", ErrorMessage = "Некорректный адрес")]
        public string Email { get; set; }
        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        public byte[] PasswordBytes
        {
            get { return ConvertStringToBytes(Password); }
        }

        private byte[] ConvertStringToBytes(string source)
        {
            return source.Encrypt();
        }

    }

}