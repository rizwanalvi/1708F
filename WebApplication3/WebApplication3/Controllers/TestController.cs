using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication3.Controllers
{
    public class TestController : Controller
    {
        productdbEntities ddEntity = null;
        // GET: Test
        public ActionResult Index()
        {
            ddEntity = new productdbEntities();
           var data  =  ddEntity.PRODUCTs.ToArray();
            return View(data);
        }
        public ActionResult Edit(int? id)
        {
            ddEntity = new productdbEntities();
            var data = ddEntity.PRODUCTs.Where(x => x.ID == id).ToArray();
            return View(data);
        }

        [HttpPost]
        public ActionResult Save(int? id)
        {
            int id01 = int.Parse(Request.Form["id"].ToString());
            ddEntity = new productdbEntities();
            var data = ddEntity.PRODUCTs.Where(x => x.ID == id01).SingleOrDefault();
            data.PRO_NAME = Request.Form["prodctName"].ToString();
            ddEntity.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}