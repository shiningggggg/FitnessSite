using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Fitness.WebUi.Controllers
{
    public class BaseController : Controller
    {
        protected override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            base.OnActionExecuting(filterContext);
            if (filterContext.HttpContext.Session["username"] == null)
            {
                filterContext.Result = new RedirectToRouteResult("LoginPage", new System.Web.Routing.RouteValueDictionary(new Dictionary<string, object> { { "controller", "Account" }, { "action", "Login" } }));
            }
        }
    }
}