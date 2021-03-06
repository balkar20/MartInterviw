﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Deploys.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            string cookie = Request.Cookies["testModule"].Value;
            ViewBag.Cookie = cookie;
            return View();
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