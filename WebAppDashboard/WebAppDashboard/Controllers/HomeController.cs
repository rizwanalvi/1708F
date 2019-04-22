using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebAppDashboard.Models;
namespace WebAppDashboard.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Product()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Product(Product pd)
        {
            return View();
        }
        [HttpGet]
        public ActionResult Order()
        {
           return View();
          //  return PartialView("_Orders");
        }
        public ActionResult Customer()
        {
            return View();
        }
       
    }
}