using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ImageHandling.Models;
namespace ImageHandling.Controllers
{
    public class HomeController : Controller
    {
        OSMEntities endb = new OSMEntities();
        // GET: Home
        public ActionResult Index()
        {

            return View(endb.PRODUCTS.ToList());
        }

        public ActionResult Create()
        {

            return View();
        }
        [HttpPost]
        public ActionResult Create(PRODUCT pd)
        {
           // endb.PRODUCTS.Add(new PRODUCT { PIMG = pd.ImgPath.FileName });
           String imgPath=  Server.MapPath("~/img/" + pd.ImgPath.FileName);
            pd.ImgPath.SaveAs(imgPath);
            //   endb.SaveChanges();
            return View();
        }


    }
}