using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebMvc02.Models;
namespace WebMvc02.Controllers
{
    public class HomeController : Controller
    {
        dbMobileEntities dbEntity = null;
        // GET: Home
        public ActionResult Index()
        {
            dbEntity = new dbMobileEntities();
           // ViewBag.Data = dbEntity.Mobiles;
            //     ViewData["DataKey"] = dbEntity.Mobiles;
            //TempData["DataKey"] = dbEntity.Mobiles;
            //ViewModel
            return View(dbEntity.Mobiles.ToList());
        }
       
        public ActionResult ShowMobile(int id)
        {
            dbEntity = new dbMobileEntities();
            var Mb = dbEntity.Mobiles.Where(x => x.ID == id).Single<Mobile>();
            ViewBag.ShowId = Mb;
            return View();
        }
        public ActionResult MobilePhone()
        {
            return View();
        }
        public ActionResult Reviews()
        {
            return View();
        }
        public ActionResult News()
        {
            return View();
        }
        public ActionResult ContactUs()
        {
            return View();
        }
        public ActionResult Outlet()
        {
            return View();
        }

        public ActionResult Tester()
        {
            dbEntity = new dbMobileEntities();
            return View(dbEntity.Mobiles.ToList());
        }


    }
}