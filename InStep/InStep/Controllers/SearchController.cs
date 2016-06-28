using InStep.Models;
using InStep.Models.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace InStep.Controllers
{
    public class SearchController : Controller
    {
        // GET: Search
        public ActionResult Index()
        {
            return View(new SearchUser());
        }

        [HttpPost]
        public ActionResult Index(SearchUser userSearch)
        {
            using (InStepContext db = new InStepContext())
            {
                IQueryable<UserProfileData> users = from t1 in db.UserData
                                       join t2 in db.UserProfiles on t1.Id equals t2.UserId into t21
                                       from t22 in t21.DefaultIfEmpty()
                                       select new UserProfileData { 
                                           Address = t22.Address,
                                           BirthDate = t1.BirthDate,
                                           CityId = t22 == null ? (int?)null : t22.CityId,
                                           CountryId = t22 == null ? (int?)null : t22.CountryId,
                                           FirstName = t1.FirstName,
                                           SecondName = t1.SecondName,
                                           LastName = t1.LastName,
                                           Sex = t1.Sex
                                       };

                if (userSearch.SearchString != null)
                    users = users.Where(r => r.LastName.Contains(userSearch.SearchString));
                if (userSearch.SearchAddres != null)
                    users = users.Where(r => r.Address.Contains(userSearch.SearchAddres));

                List<UserProfileData> data = new List<UserProfileData>();
                foreach(var item in users.ToList())
                {
                    UserProfileData u = new UserProfileData();
                    u.FirstName = item.FirstName;
                    u.SecondName = item.SecondName;
                    u.LastName = item.LastName;
                    u.Sex = item.Sex;
                    u.BirthDate = item.BirthDate;
                    u.CityId = item.CityId;
                    u.CountryId = item.CountryId;
                    u.Address = item.Address;
                    data.Add(u);
                }
                userSearch.Users = data;
            }

            return View(userSearch);
        }
    }
}