using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
namespace WebAppAuthoriz.Controllers
{
    [Authorize]
    public class HomeController : Controller
    {
        
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }
        [Authorize]
        public ActionResult Home()
        {
            return View();
        }
        [AllowAnonymous]
        public ActionResult Login() {
            return View();
        }
        [AllowAnonymous]
        [HttpPost]
        public ActionResult Login(int? i)
        {
            String UName = "Admin";
            String Upass = "Admin";
            if (UName == "Admin" && Upass == "Admin") {
                FormsAuthentication.SetAuthCookie(UName, false);
            }
            return RedirectToAction("Home");
        }

        public ActionResult Logout()
        {
            FormsAuthentication.SignOut();
            return RedirectToAction("Index");
        }
    }
}