using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Webmvc01.Models;
namespace Webmvc01.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            String PgName = "Home";
            ViewBag.PageTitle = PgName;
            return View();
        }

 

        public ActionResult AboutUs()
        {
            Contact ac = new Contact {ContactId=100,Location= "Karachi",Address= "Happy Homes Decent Arcade anbcbajj " };
            ViewBag.PageTitle = ac;
            return View();
        }

    }
}