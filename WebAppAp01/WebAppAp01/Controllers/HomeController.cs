using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebAppAp01.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult LoginOut() {

           return RedirectToAction("Index");
        }

        public ActionResult Login()
        {
            switch ("")
            {
                case "GM":
                return RedirectToAction("Index", "GernalManager");
                    break;
                case "MG":
                    return RedirectToAction("Index", "Manager");
                    break;
                case "CAH":
                    return RedirectToAction("Index", "AcadmicHead");
                    break;
                case "GL":
                    return RedirectToAction("Index", "GroupLeader");
                    break;
                case "FA":
                    return RedirectToAction("Index", "Faculty");
                    break;
                case "CC":
                    return RedirectToAction("Index", "CareerCounselor");
                    break;
                case "SRO":
                    return RedirectToAction("Index", "SRO");
                    break;

                default:
                    break;
            }
            return View();
        }
    }
}