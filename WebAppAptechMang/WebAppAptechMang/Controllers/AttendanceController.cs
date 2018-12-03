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
    public class AttendanceController : Controller
    {
        private APTECHDBEntities db = new APTECHDBEntities();

        // GET: Attendance
        public ActionResult Index()
        {
            var aTTENDANCEs = db.ATTENDANCEs.Include(a => a.SEMESTER).Include(a => a.COURS);
            return View(aTTENDANCEs.ToList());
        }

        // GET: Attendance/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ATTENDANCE aTTENDANCE = db.ATTENDANCEs.Find(id);
            if (aTTENDANCE == null)
            {
                return HttpNotFound();
            }
            return View(aTTENDANCE);
        }

        // GET: Attendance/Create
        public ActionResult Create()
        {
            ViewBag.SEM_ID = new SelectList(db.SEMESTERS, "SEM_ID", "SEM_TITLE");
            ViewBag.COURSE_ID = new SelectList(db.COURSES, "COURSE_ID", "COURSE_TITLE");
            return View();
        }

        // POST: Attendance/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,STUDENT_ID,STD_NAME,COURSE_ID,COURSE_CODE,BATCH_ID,ATT_DATE,SEM_ID,SESS_PORTAL,SESS_COURSE,MARK_ATTEND,FOLLOWUP,ISFOLLOWUP")] ATTENDANCE aTTENDANCE)
        {
            if (ModelState.IsValid)
            {
                db.ATTENDANCEs.Add(aTTENDANCE);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.SEM_ID = new SelectList(db.SEMESTERS, "SEM_ID", "SEM_TITLE", aTTENDANCE.SEM_ID);
            ViewBag.COURSE_ID = new SelectList(db.COURSES, "COURSE_ID", "COURSE_TITLE", aTTENDANCE.COURSE_ID);
            return View(aTTENDANCE);
        }

        // GET: Attendance/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ATTENDANCE aTTENDANCE = db.ATTENDANCEs.Find(id);
            if (aTTENDANCE == null)
            {
                return HttpNotFound();
            }
            ViewBag.SEM_ID = new SelectList(db.SEMESTERS, "SEM_ID", "SEM_TITLE", aTTENDANCE.SEM_ID);
            ViewBag.COURSE_ID = new SelectList(db.COURSES, "COURSE_ID", "COURSE_TITLE", aTTENDANCE.COURSE_ID);
            return View(aTTENDANCE);
        }

        // POST: Attendance/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,STUDENT_ID,STD_NAME,COURSE_ID,COURSE_CODE,BATCH_ID,ATT_DATE,SEM_ID,SESS_PORTAL,SESS_COURSE,MARK_ATTEND,FOLLOWUP,ISFOLLOWUP")] ATTENDANCE aTTENDANCE)
        {
            if (ModelState.IsValid)
            {
                db.Entry(aTTENDANCE).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.SEM_ID = new SelectList(db.SEMESTERS, "SEM_ID", "SEM_TITLE", aTTENDANCE.SEM_ID);
            ViewBag.COURSE_ID = new SelectList(db.COURSES, "COURSE_ID", "COURSE_TITLE", aTTENDANCE.COURSE_ID);
            return View(aTTENDANCE);
        }

        // GET: Attendance/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ATTENDANCE aTTENDANCE = db.ATTENDANCEs.Find(id);
            if (aTTENDANCE == null)
            {
                return HttpNotFound();
            }
            return View(aTTENDANCE);
        }

        // POST: Attendance/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            ATTENDANCE aTTENDANCE = db.ATTENDANCEs.Find(id);
            db.ATTENDANCEs.Remove(aTTENDANCE);
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
