using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using WebAppAptechMang;

namespace WebAppAptechMang.Controllers
{
    public class ApPorgramController : Controller
    {
        private APTECHDBEntities db = new APTECHDBEntities();

        // GET: ApPorgram
        public ActionResult Index()
        {
            return View(db.APPROGRAMs.ToList());
        }

        // GET: ApPorgram/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            APPROGRAM aPPROGRAM = db.APPROGRAMs.Find(id);
            if (aPPROGRAM == null)
            {
                return HttpNotFound();
            }
            return View(aPPROGRAM);
        }

        // GET: ApPorgram/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ApPorgram/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,PROG_NAME,SEM_CURRCULUM")] APPROGRAM aPPROGRAM)
        {
            if (ModelState.IsValid)
            {
                db.APPROGRAMs.Add(aPPROGRAM);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(aPPROGRAM);
        }

        // GET: ApPorgram/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            APPROGRAM aPPROGRAM = db.APPROGRAMs.Find(id);
            if (aPPROGRAM == null)
            {
                return HttpNotFound();
            }
            return View(aPPROGRAM);
        }

        // POST: ApPorgram/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,PROG_NAME,SEM_CURRCULUM")] APPROGRAM aPPROGRAM)
        {
            if (ModelState.IsValid)
            {
                db.Entry(aPPROGRAM).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(aPPROGRAM);
        }

        // GET: ApPorgram/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            APPROGRAM aPPROGRAM = db.APPROGRAMs.Find(id);
            if (aPPROGRAM == null)
            {
                return HttpNotFound();
            }
            return View(aPPROGRAM);
        }

        // POST: ApPorgram/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            APPROGRAM aPPROGRAM = db.APPROGRAMs.Find(id);
            db.APPROGRAMs.Remove(aPPROGRAM);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
