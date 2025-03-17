using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using validation.Models;

namespace validation.Controllers
{
    public class StudentController : Controller
    {


        // GET: Student
        [HttpGet]
        public ActionResult Index()
        {
            return View(new Student());
        }
        [HttpPost]
        public ActionResult Index(Student s)
        {
            if (ModelState.IsValid)
            {
                return RedirectToAction("About", "Home");
            }
            return View(s);
        }

    }
}