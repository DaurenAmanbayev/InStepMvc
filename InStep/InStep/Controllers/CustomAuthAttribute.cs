using InStep.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace InStep.Controllers
{
    public class CustomAuthAttribute : AuthorizeAttribute
    {

        protected override void HandleUnauthorizedRequest(AuthorizationContext filterContext)
        {
            bool auth = filterContext.HttpContext.User.Identity.IsAuthenticated;
            var url = HttpContext.Current.Request.Url.PathAndQuery;
            if (!auth && !url.Contains("/Home/Main") && url != "/" && !url.Contains("/Home/Login") && !url.Contains("/Home/Logout"))
            {
                filterContext.Result = new RedirectToRouteResult(
               new RouteValueDictionary(new { controller = "Home", action = "Main" }));
            }
        }
    }
}