using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using mvc1.Filters;
using mvc1.Models;

namespace mvc1.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            TempData["myData"] = "hi";
            //var data = RouteData.Values
            //var key = data.Keys;
             Phone phone = new Phone
            {
                Id = 1, 
                Model = "Iphone6s", 
                Producer = "Apple"
            };
            TempData.Keep();
            return View(phone);
        }

        public PartialViewResult Son()
        {
            return PartialView("Son");
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        
        public ActionResult RouteSample()
        {
            var hi = RouteData.Values["hi"].ToString();
            var route = RouteData.Values["route"].ToString();
            ViewBag.Route = route;
            ViewBag.Hi = hi;
            ViewBag.Message = "Your route sample";

            return View();
        }        

        [Route("~/Test")]
        public ActionResult ActionName()
        {
            ViewBag.Controller = "Customer";
            ViewBag.Action = "Index";

            return View();
        }
    }
}