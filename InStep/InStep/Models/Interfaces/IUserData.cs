using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace InStep.Models.Interfaces
{
    public interface IUserData
    {
        string FirstName { get; set; }
        string LastName { get; set; }
        string SecondName { get; set; }
        bool Sex { get; set; }
        DateTime BirthDate { get; set; }
        string PhoneNumber { get; set; }
    }
}