using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Intro

namespace FirstAsp.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
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
        public ActionResult Description()
        {
            ViewData["Name","Id","Course Complete"] =
            return View();
        }


        public ActionResult Name()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}