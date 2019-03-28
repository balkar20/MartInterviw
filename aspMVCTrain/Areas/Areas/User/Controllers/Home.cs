using System.Web.Mvc;

namespace Areas.Areas.User.Controllers
{
    public class Home : Controller
    {
        // GET
        public ActionResult Index()
        {
            return
            View();
        }
    }
}