using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using mvc1.Models;

namespace mvc1.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            var user = ControllerContext.HttpContext.User;
        }

        public ActionResult BookInfo()
        {
            Book book = new Book()
            {
                Id = 1,
                Name = "Stalker",
                Author = "Vlad",
                Year = 1999
            };

            return View(book);
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}