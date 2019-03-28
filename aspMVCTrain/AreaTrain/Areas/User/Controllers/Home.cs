using System.Web.Mvc;

namespace AreaTrain.Areas.User.Controllers
{
    public class HomeController : Controller
    {
        // GET
        public ActionResult Index()
        {
            return
            View();
        }
    }
}