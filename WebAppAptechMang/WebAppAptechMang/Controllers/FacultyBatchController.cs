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
    public class FacultyBatchController : Controller
    {
        private APTECHDBEntities db = new APTECHDBEntities();

        // GET: FacultyBatch
        public ActionResult Index()
        {
            var fACUTLY_BATCH = db.FACUTLY_BATCH.Include(f => f.BATCH_REGISTRATION).Include(f => f.FACULTY);
            return View(fACUTLY_BATCH.ToList());
        }

        // GET: FacultyBatch/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            FACUTLY_BATCH fACUTLY_BATCH = db.FACUTLY_BATCH.Find(id);
            if (fACUTLY_BATCH == null)
            {
                return HttpNotFound();
            }
            return View(fACUTLY_BATCH);
        }

        // GET: FacultyBatch/Create
        public ActionResult Create()
        {
            ViewBag.FA_BATCHNO = new SelectList(db.BATCH_REGISTRATION, "BACTCH_NO", "REMARKS");
            ViewBag.ID = new SelectList(db.FACULTies, "ID", "FA_NAME");
            return View();
        }

        // POST: FacultyBatch/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "FA_BA_ID,ID,FA_CODE,FA_BATCHNO,FA_TIME_SLOT")] FACUTLY_BATCH fACUTLY_BATCH)
        {
            if (ModelState.IsValid)
            {
                db.FACUTLY_BATCH.Add(fACUTLY_BATCH);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.FA_BATCHNO = new SelectList(db.BATCH_REGISTRATION, "BACTCH_NO", "REMARKS", fACUTLY_BATCH.FA_BATCHNO);
            ViewBag.ID = new SelectList(db.FACULTies, "ID", "FA_NAME", fACUTLY_BATCH.ID);
            return View(fACUTLY_BATCH);
        }

        // GET: FacultyBatch/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            FACUTLY_BATCH fACUTLY_BATCH = db.FACUTLY_BATCH.Find(id);
            if (fACUTLY_BATCH == null)
            {
                return HttpNotFound();
            }
            ViewBag.FA_BATCHNO = new SelectList(db.BATCH_REGISTRATION, "BACTCH_NO", "REMARKS", fACUTLY_BATCH.FA_BATCHNO);
            ViewBag.ID = new SelectList(db.FACULTies, "ID", "FA_NAME", fACUTLY_BATCH.ID);
            return View(fACUTLY_BATCH);
        }

        // POST: FacultyBatch/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "FA_BA_ID,ID,FA_CODE,FA_BATCHNO,FA_TIME_SLOT")] FACUTLY_BATCH fACUTLY_BATCH)
        {
            if (ModelState.IsValid)
            {
                db.Entry(fACUTLY_BATCH).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.FA_BATCHNO = new SelectList(db.BATCH_REGISTRATION, "BACTCH_NO", "REMARKS", fACUTLY_BATCH.FA_BATCHNO);
            ViewBag.ID = new SelectList(db.FACULTies, "ID", "FA_NAME", fACUTLY_BATCH.ID);
            return View(fACUTLY_BATCH);
        }

        // GET: FacultyBatch/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            FACUTLY_BATCH fACUTLY_BATCH = db.FACUTLY_BATCH.Find(id);
            if (fACUTLY_BATCH == null)
            {
                return HttpNotFound();
            }
            return View(fACUTLY_BATCH);
        }

        // POST: FacultyBatch/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            FACUTLY_BATCH fACUTLY_BATCH = db.FACUTLY_BATCH.Find(id);
            db.FACUTLY_BATCH.Remove(fACUTLY_BATCH);
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
