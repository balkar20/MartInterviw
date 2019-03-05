using System.Web.Mvc;

namespace mvc1.Controllers
{
    public class AccountController : Controller
    {
        // GET
        public ActionResult Login()
        {
            return View();
        }
    }
}