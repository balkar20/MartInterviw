using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using FiltersAndAuth.Models;
using FiltersAndAuth.Providers;
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

        public string BrowserInfo(string browser)
        {
            return browser;
        }

        public string BookInfo(Book book)
        {
            return book.Name;
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