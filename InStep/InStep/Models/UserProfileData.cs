using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace InStep.Models
{
    public class UserProfileData
    {
        // Местоположение
        public int? CountryId { get; set; }
        public int? CityId { get; set; }
        public string Address { get; set; }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string SecondName { get; set; }
        public bool Sex { get; set; }
        public DateTime BirthDate { get; set; }
    }
}