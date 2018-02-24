using Fitness.BLL;
using Fitness.Model.Entities;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Web.Mvc;
using Fitness.IBLL;
using Autofac;

namespace Fitness.WebUi.Controllers
{
    //[Authorize]
    public class HomeController : Controller
    {
        IUsersService _userService = ServiceManager.ServiceContainer.Resolve<IUsersService>();
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }   
        public ActionResult UserAnalysis()
        {
            return View();
        }
        [HttpPost]
        public string GetUserPageData(int page)
        {
            int pageIndex = page;
            int pageSize = 10;
            int rowCount = 0;
            List<LoginViewModel> list = _userService.GetUsersData(pageIndex, pageSize, out rowCount);
            int pageCount = rowCount % pageSize != 0 ? rowCount / pageSize + 1 : rowCount / pageSize;
            string json_data = "{\"pageCount\":" + pageCount + ",\"currentPage\":" + pageIndex + ",\"list\":" + JsonConvert.SerializeObject(list) + "}";
            return json_data;
        }
        [HttpGet]
        public string GetUserJson()
        {
            //int rowCount = 0;
            //List<Inn_Users> list = userService.GetUsersData(1, int.MaxValue,out rowCount);
            //var pieList = from l in list
            //              group l by new { l.Birthday.Value.Year } into temp
            //              let userNum = temp.Count()
            //              select new
            //              {
            //                  name = temp.Key.Year,
            //                  value =userNum
            //              };
            //return JsonConvert.SerializeObject(pieList);
            return "";
        }
    }
}