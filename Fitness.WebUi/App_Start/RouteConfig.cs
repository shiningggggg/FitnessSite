using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace Fitness.WebUi
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");
            //自定义路由-需要放到默认路由前面
            routes.MapRoute(
            "LoginPage",
            "Login/Page",
            new { controller = "Account", action = "Login" }
            );
            routes.MapRoute(
                "RegisterPage",
                "Register/Page",
                new { controller = "Account", action = "Register" }
                );
            routes.MapRoute(
                "InvitationPage",
                "Invitation/Page",
                new { controller = "Invitation", action = "Index" }
                );
            routes.MapRoute(
                "ArticlePage",
                "Article/Page",
                new { controller = "Article", action = "Index" }
                );
            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
