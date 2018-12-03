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
    public class AcadmicController : Controller
    {
        private APTECHDBEntities db = new APTECHDBEntities();

        // GET: Acadmic
        public ActionResult Index()
        {
            return View(db.ACADMICS.ToList());
        }

        // GET: Acadmic/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ACADMIC aCADMIC = db.ACADMICS.Find(id);
            if (aCADMIC == null)
            {
                return HttpNotFound();
            }
            return View(aCADMIC);
        }

        // GET: Acadmic/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Acadmic/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,STD_ID,PASS_YEAR")] ACADMIC aCADMIC)
        {
            if (ModelState.IsValid)
            {
                db.ACADMICS.Add(aCADMIC);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(aCADMIC);
        }

        // GET: Acadmic/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ACADMIC aCADMIC = db.ACADMICS.Find(id);
            if (aCADMIC == null)
            {
                return HttpNotFound();
            }
            return View(aCADMIC);
        }

        // POST: Acadmic/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,STD_ID,PASS_YEAR")] ACADMIC aCADMIC)
        {
            if (ModelState.IsValid)
            {
                db.Entry(aCADMIC).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(aCADMIC);
        }

        // GET: Acadmic/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ACADMIC aCADMIC = db.ACADMICS.Find(id);
            if (aCADMIC == null)
            {
                return HttpNotFound();
            }
            return View(aCADMIC);
        }

        // POST: Acadmic/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            ACADMIC aCADMIC = db.ACADMICS.Find(id);
            db.ACADMICS.Remove(aCADMIC);
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
