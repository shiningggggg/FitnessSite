using Autofac;
using Fitness.BLL;
using Fitness.IBLL;
using Fitness.Model.Entities;
using System.Linq;
using System.Web.Mvc;

namespace Fitness.WebUi.Controllers
{
    public class ArticleController : Controller
    {
        IArticleService articleSerivce = ServiceManager.ServiceContainer.Resolve<IArticleService>();
        // GET: Article
        public ActionResult Index()
        {
            Article model = articleSerivce.GetArticleModel().FirstOrDefault();
            return View(model);
        }
        public ActionResult TestCKEditor()
        {
            return View();
        }
    }
}