using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SimpleCapaApp.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "This is a test application that uses CAPA";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Team #1";

            return View();
        }
    }
}