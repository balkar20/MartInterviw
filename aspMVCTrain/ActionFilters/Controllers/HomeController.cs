using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ActionFilters.Filters;

namespace ActionFilters.Controllers
{
    public class HomeController : Controller
    {
        [MyAction]
        public string Index()
        {
            return "Hello";
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