using InStep.App_Start;
using InStep.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using System.Web.Security;

namespace InStep
{
    public class MvcApplication : System.Web.HttpApplication
    {
        public MvcApplication()
        {
            this.AuthorizeRequest += MvcApplication_AuthorizeRequest;
        }

        private const string cookieName = "__AUTH_COOKIE";
        void MvcApplication_AuthorizeRequest(object sender, EventArgs e)
        {
            HttpCookie authCookie = Context.Request.Cookies.Get(cookieName);
            if (authCookie != null && !string.IsNullOrEmpty(authCookie.Value))
            {
                var ticket = FormsAuthentication.Decrypt(authCookie.Value);
               HttpContext.Current.User = new UserPrincipal(ticket.Name);
            }
        }

        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
        }
    }
}
