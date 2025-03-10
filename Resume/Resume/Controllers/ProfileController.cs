using Antlr.Runtime.Misc;
using Resume.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Web;
using System.Web.Mvc;

namespace Resume.Controllers
{
    public class ProfileController : Controller
    {
        // GET: Profile
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Education()
        {
            Education S1 = new Education();
            S1.Degree = "BSC in Computer Sceince";
            S1.Institute = "American International University Bangladesh";
            S1.Year = 2026;
            S1.Cgpa = 3.92f;
            Education S2 = new Education();
            S2.Degree = "SSC in Science";
            S2.Institute = "Bangladesh International School and College ,Jeddah";

            S2.Year = 2019;
            S2.Cgpa = 5.00f;
            Education S3 = new Education();
            S3.Degree = "HSC in Science";
            S3.Institute = "Bangladesh International School and College ,Jeddah";
            S3.Year = 2021;
            S3.Cgpa = 5.00f;

            Education[] educations = new Education[]{ S1, S2, S3 };
            return View(educations);
        }
        public ActionResult Projects()
        {
            Project S1 = new Project();
            S1.Title = "ConnectNation";
            S1.Course = "Webtech";
            S1.Description = "Its social media,People can post , like ,comments and also report . There are 2 type user Admin and User";
            Project S2 = new Project();
            S2.Title = "NID management System";
            S2.Course = "App development : Flutter";
            S2.Description = "User can registration for their nid,correct thier information through Mobile Apps";
            Project[] projects = new Project[] {S2,S1};
            return View(projects);

        }
        public ActionResult Ref()
        {
            reference s1 = new reference();
            reference s2 = new reference();
            reference s3 = new reference();

            s1.name = "Dip Nandi";
            s1.position = "Associate Dean,FST,AIUB";
            s1.Course = "Research Methology";


            s2.name = "MOHAIMEN- BIN- NOOR";
            s2.position = "Special Assistant,FST,AIUB";
            s2.Course = "Data Structure";


            s3.name = "Rifath Mahmud";
            s3.position = "Assistant Professor,FST,AIUB";
            s3.Course = "Data Structure Lab";

            reference[] refs = new reference[] { s1, s2, s3 };
            return View(refs);
        }

    }
}