using Autofac;
using Fitness.BLL;
using Fitness.IBLL;
using Fitness.Model.Entities;
using System.Collections.Generic;
using System.Web.Mvc;

namespace Fitness.WebUi.Controllers
{
    public class InvitationController : Controller
    {
        //用此种方式的Autofac需要在每个页面引用Autofac，可以换一种，通过注册的方式控制器的方式，在其构造方法中实例接口对象
        IInvitationService service = ServiceManager.ServiceContainer.Resolve<IInvitationService>();
        // GET: Invitation
        public ActionResult Index()
        {
            List<Invitation> list = service.GetInvitationList();
            return View(list);
        }
    }
}