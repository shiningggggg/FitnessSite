using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Fitness.WebUi.Controllers
{
    public class TestController : Controller
    {
        // GET: Test
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult EchartsView()
        {
            return View();
        }
        public ActionResult EchartsViewPie()
        {
            return View();
        }

        public ActionResult FullCalendar()
        {
            return View();
        }

        public ActionResult BootstrapCalendar()
        {
            return View();
        }
    }
}