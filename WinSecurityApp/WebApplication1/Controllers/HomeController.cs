using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using GisTech;
namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            String Data = "Abc";
            ViewBag.MyData = GisTechSecurity.EncryptionTriDes(Data);
            return View();
        }
    }
}