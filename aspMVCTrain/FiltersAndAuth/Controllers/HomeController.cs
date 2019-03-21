using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using mvc1.Filters;

namespace FiltersAndAuth.Controllers
{
    public class HomeController : Controller
    {
        [MyAuthAttribut]
        [CustomAuth]
        public string Index()
        {
            return "You entred!";
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}