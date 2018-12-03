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
    public class FacultyBatchIdController : Controller
    {
        private APTECHDBEntities db = new APTECHDBEntities();

        // GET: FacultyBatchId
        public ActionResult Index()
        {
            return View(db.VMBACTH_FA.ToList());
        }

        // GET: FacultyBatchId/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            VMBACTH_FA vMBACTH_FA = db.VMBACTH_FA.Find(id);
            if (vMBACTH_FA == null)
            {
                return HttpNotFound();
            }
            return View(vMBACTH_FA);
        }

        // GET: FacultyBatchId/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: FacultyBatchId/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,FA_NAME,FA_EMAILID,BATCHDATA,ENROLL_STD,DAYS_CODE")] VMBACTH_FA vMBACTH_FA)
        {
            if (ModelState.IsValid)
            {
                db.VMBACTH_FA.Add(vMBACTH_FA);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(vMBACTH_FA);
        }

        // GET: FacultyBatchId/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            VMBACTH_FA vMBACTH_FA = db.VMBACTH_FA.Find(id);
            if (vMBACTH_FA == null)
            {
                return HttpNotFound();
            }
            return View(vMBACTH_FA);
        }

        // POST: FacultyBatchId/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,FA_NAME,FA_EMAILID,BATCHDATA,ENROLL_STD,DAYS_CODE")] VMBACTH_FA vMBACTH_FA)
        {
            if (ModelState.IsValid)
            {
                db.Entry(vMBACTH_FA).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(vMBACTH_FA);
        }

        // GET: FacultyBatchId/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            VMBACTH_FA vMBACTH_FA = db.VMBACTH_FA.Find(id);
            if (vMBACTH_FA == null)
            {
                return HttpNotFound();
            }
            return View(vMBACTH_FA);
        }

        // POST: FacultyBatchId/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            VMBACTH_FA vMBACTH_FA = db.VMBACTH_FA.Find(id);
            db.VMBACTH_FA.Remove(vMBACTH_FA);
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
