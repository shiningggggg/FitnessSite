using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Fitness.WebUi.Utilies
{
    public class AuthenticationAttribute:ActionFilterAttribute
    {
        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            if (filterContext.HttpContext.Session["username"] == null)
            {
                filterContext.Result = new RedirectToRouteResult("LoginPage", new System.Web.Routing.RouteValueDictionary(new Dictionary<string, object>() { { "controller", "Account" }, { "action", "Login" } }));
            }
            base.OnActionExecuting(filterContext);
        }
    }
}