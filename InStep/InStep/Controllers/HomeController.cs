using InStep.Models;
using InStep.Models.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace InStep.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Main()
        {
            if (HttpContext.User.Identity.IsAuthenticated)
            {
                return RedirectToAction("Profile");
            }
            return View(new AuthUser());
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Login(AuthUser user)
        {
            if (ModelState.IsValid)
            {

                UserData userd = null;
                using (InStepContext db = new InStepContext())
                {
                    userd = db.UserData.FirstOrDefault(p => p.Email == user.Email && p.Password == user.PasswordBytes);
                }
                if (userd != null)
                {
                    CreateCookie(user.Email);
                    return Redirect("Profile");
                }
                else
                {
                    ModelState.AddModelError("", "Неверный логин или пароль");
                }
            }

            return View("Main", user);
        }
        
        public ActionResult Profile()
        {
            return View();
        }

        private const string cookieName = "__AUTH_COOKIE";
        private void CreateCookie(string userName, bool isPersistent = false)
        {
            var ticket = new FormsAuthenticationTicket(
                  1,
                  userName,
                  DateTime.Now,
                  DateTime.Now.Add(FormsAuthentication.Timeout),
                  isPersistent,
                  string.Empty,
                  FormsAuthentication.FormsCookiePath);

            var encTicket = FormsAuthentication.Encrypt(ticket);
            var AuthCookie = new HttpCookie(cookieName)
            {
                Value = encTicket,
                Expires = DateTime.Now.Add(FormsAuthentication.Timeout)
            };
            HttpContext.Response.Cookies.Set(AuthCookie);
        }

        public ActionResult Logout()
        {
            var AuthCookie = new HttpCookie(cookieName)
            {
                Expires = DateTime.Now.AddDays(-1)
            };
            HttpContext.Response.Cookies.Set(AuthCookie);
            return Redirect("Main");
        }

        public ActionResult Registration()
        {
            return View(new RegisterUserData());
        }

        [HttpPost]
        public ActionResult Registration(RegisterUserData user)
        {
            if (ModelState.IsValid)
            {
                using (InStepContext DB = new InStepContext())
                {
                    UserData us = new UserData(user);
                    DB.UserData.Add(us);
                    DB.SaveChanges();
                }
            }
            return View(user);
        }
    }
}