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
    public class BatchRegistrationController : Controller
    {
        private APTECHDBEntities db = new APTECHDBEntities();

        // GET: BatchRegistration
        public ActionResult Index()
        {
            return View(db.BATCH_REGISTRATION.ToList());
        }

        // GET: BatchRegistration/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            BATCH_REGISTRATION bATCH_REGISTRATION = db.BATCH_REGISTRATION.Find(id);
            if (bATCH_REGISTRATION == null)
            {
                return HttpNotFound();
            }
            return View(bATCH_REGISTRATION);
        }

        // GET: BatchRegistration/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: BatchRegistration/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "BACTCH_NO,TIME_SLOT,DAYID,ENROLL_STD,START_DATE,EX_END_DATE,END_DATE,REMARKS,ISACTIVE")] BATCH_REGISTRATION bATCH_REGISTRATION)
        {
            if (ModelState.IsValid)
            {
                db.BATCH_REGISTRATION.Add(bATCH_REGISTRATION);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(bATCH_REGISTRATION);
        }

        // GET: BatchRegistration/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            BATCH_REGISTRATION bATCH_REGISTRATION = db.BATCH_REGISTRATION.Find(id);
            if (bATCH_REGISTRATION == null)
            {
                return HttpNotFound();
            }
            return View(bATCH_REGISTRATION);
        }

        // POST: BatchRegistration/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "BACTCH_NO,TIME_SLOT,DAYID,ENROLL_STD,START_DATE,EX_END_DATE,END_DATE,REMARKS,ISACTIVE")] BATCH_REGISTRATION bATCH_REGISTRATION)
        {
            if (ModelState.IsValid)
            {
                db.Entry(bATCH_REGISTRATION).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(bATCH_REGISTRATION);
        }

        // GET: BatchRegistration/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            BATCH_REGISTRATION bATCH_REGISTRATION = db.BATCH_REGISTRATION.Find(id);
            if (bATCH_REGISTRATION == null)
            {
                return HttpNotFound();
            }
            return View(bATCH_REGISTRATION);
        }

        // POST: BatchRegistration/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            BATCH_REGISTRATION bATCH_REGISTRATION = db.BATCH_REGISTRATION.Find(id);
            db.BATCH_REGISTRATION.Remove(bATCH_REGISTRATION);
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
