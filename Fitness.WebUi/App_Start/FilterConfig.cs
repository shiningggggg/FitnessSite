using Fitness.WebUi.Utilies;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Fitness.WebUi
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
            //如果让整个项目的所有Action都使用此过滤器
            //filter.Add(new AuthenticationAttribute());
        }
    }
}