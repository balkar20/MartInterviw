using System.Web.Mvc;

namespace mvc1.Controllers
{
    public class LegacyController : Controller
    {
        public ActionResult GetLegacyURL(string legacyURL)
        {
            var values = RouteData.Values;
            return View((object)legacyURL);
        }
    }
}