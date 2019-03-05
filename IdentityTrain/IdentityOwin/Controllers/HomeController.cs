using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using IdentityOwin.Models;

namespace IdentityOwin.Controllers
{
    [Authorize]
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
        [Authorize(Roles = "admin")]
        public ActionResult About()
        {
            ViewBag.Message = User.Identity.GetUserRole();

            return View();
        }
        public ActionResult Contact()
        {
            int id = User.Identity.GetUserId<int>();
            ViewBag.Message = "Ваш id: " + id.ToString();

            return View();
        }
    }
}
