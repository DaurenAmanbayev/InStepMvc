using InStep.Models.Context;
using InStep.Models.Dictionaries;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace InStep.Models
{
    public class SearchUser
    {
        public SearchUser()
        {
            using (InStepContext Db = new InStepContext())
            {
                Countries = Db.Countries.ToList();
                Cities = Db.Cities.ToList();
            }
        }
        public string SearchAddres { get; set; }
        public string SearchString { get; set; }
        public bool SearchSex { get; set; }
        public DateTime SearchBirthDate { get; set; }

        public IEnumerable<UserProfileData> Users { get; set; }
        public IEnumerable<Country> Countries { get; set; }
        public IEnumerable<City> Cities { get; set; }
    }
}