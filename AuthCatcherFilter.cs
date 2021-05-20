using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication1
{
    public class AuthCatcherFilter : IAuthorizationFilter
    {
        public void OnAuthorization(AuthorizationContext filterContext)
        {
            var authorize = filterContext.ActionDescriptor.GetFilterAttributes(true);

            if (authorize.Count() == 0)
                return;

            bool isLoggedIn = filterContext.HttpContext.User.Identity.IsAuthenticated;


            if (!isLoggedIn)
            {
                filterContext.Result = new RedirectToRouteResult(new System.Web.Routing.RouteValueDictionary(new
                {
                    controller = "Error",
                    action = "Login"
                }));
                return;
            }
        }
    }
}