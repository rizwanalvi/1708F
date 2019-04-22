using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebTester.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult PrePaid()
        {
            return View();
        }
        public ActionResult PostPaid()
        {
            return View();
        }
    }
}