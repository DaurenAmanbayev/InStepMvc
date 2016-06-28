using InStep.Models;
using InStep.Models.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace InStep.Controllers
{
    public class SettingController : Controller
    {
        // GET: Setting
        public ActionResult Index()
        {
            var email = HttpContext.User.Identity.Name;
            using (InStepContext db = new InStepContext())
            {
                var user = db.UserData.FirstOrDefault(p => p.Email == email);
                var settingUser = new SettingUser { 
                    Email = user.Email,
                    FirstName = user.FirstName,
                    LastName = user.LastName,
                    PhoneNumber = user.PhoneNumber,
                    SecondName = user.SecondName,
                    Sex = user.Sex
                };
                return View(settingUser);
            }            
        }

        [HttpPost]
        public ActionResult SettingProfile(SettingUser user)
        {
            if (ModelState.IsValid)
            {
                UserData ud;
                using (InStepContext db = new InStepContext())
                {
                    ud = db.UserData.FirstOrDefault(p => p.Email==user.Email);
                    ud.FirstName = user.FirstName;
                    ud.SecondName = user.SecondName;
                    ud.LastName = user.LastName;
                    ud.PhoneNumber = user.PhoneNumber;
                    ud.Sex = user.Sex;
                    db.SaveChanges();
                    return Redirect("/Home/Profile");
                }
            }

            return View("Index",user);
        }
    }
}