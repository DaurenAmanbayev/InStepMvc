using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Web;

namespace InStep.Models.Interfaces
{
    public interface IRegisterUserData : IUserData
    {
        string Email { get; set; }
        string Password { get; set; }
    }
}