using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Webmvc01.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            String PgName = "HOME";
            ViewBag.PageTitle = PgName;
            return View();
        }

        public ActionResult AboutUs()
        {
            ViewBag.PageTitle = "ABOUT US";
            return View();
        }

    }
}