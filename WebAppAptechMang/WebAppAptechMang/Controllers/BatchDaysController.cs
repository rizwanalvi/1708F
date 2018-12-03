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
    public class BatchDaysController : Controller
    {
        private APTECHDBEntities db = new APTECHDBEntities();

        // GET: BatchDays
        public ActionResult Index()
        {
            return View(db.BATCHDAYS.ToList());
        }

        // GET: BatchDays/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            BATCHDAY bATCHDAY = db.BATCHDAYS.Find(id);
            if (bATCHDAY == null)
            {
                return HttpNotFound();
            }
            return View(bATCHDAY);
        }

        // GET: BatchDays/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: BatchDays/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "DAYID,DAYS_CODE")] BATCHDAY bATCHDAY)
        {
            if (ModelState.IsValid)
            {
                db.BATCHDAYS.Add(bATCHDAY);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(bATCHDAY);
        }

        // GET: BatchDays/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            BATCHDAY bATCHDAY = db.BATCHDAYS.Find(id);
            if (bATCHDAY == null)
            {
                return HttpNotFound();
            }
            return View(bATCHDAY);
        }

        // POST: BatchDays/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "DAYID,DAYS_CODE")] BATCHDAY bATCHDAY)
        {
            if (ModelState.IsValid)
            {
                db.Entry(bATCHDAY).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(bATCHDAY);
        }

        // GET: BatchDays/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            BATCHDAY bATCHDAY = db.BATCHDAYS.Find(id);
            if (bATCHDAY == null)
            {
                return HttpNotFound();
            }
            return View(bATCHDAY);
        }

        // POST: BatchDays/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            BATCHDAY bATCHDAY = db.BATCHDAYS.Find(id);
            db.BATCHDAYS.Remove(bATCHDAY);
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
