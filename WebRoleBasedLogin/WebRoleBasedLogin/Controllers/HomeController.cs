using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using WebRoleBasedLogin.Models;
namespace WebRoleBasedLogin.Controllers
{
    public class HomeController : Controller
    {
        OnlineMallEntities _ome = new OnlineMallEntities();
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }


        [HttpPost]
        public ActionResult Index(User user)
        {
            int _flag = _ome.Users.Where(m => m.UserName == user.UserName && m.UsePassword == user.UsePassword).Count();
         int _roleid=   _ome.Users.Where(m => m.UserName == user.UserName && m.UsePassword == user.UsePassword).Single().UserRole.Role_Id;
            if (_flag > 0) {

                FormsAuthentication.SetAuthCookie(user.UserName, false);
                switch (_roleid)
                {
                    case 1:
                        return RedirectToAction("Index", "Admin");
                        break;
                    case 2:
                        return RedirectToAction("Index", "User");
                        break;
                    default:
                        break;
                }

               
            }
            return View();
        }

        public ActionResult LogOut() {

            FormsAuthentication.SignOut();
            return RedirectToAction("Index", "Home");
        }


    }
}