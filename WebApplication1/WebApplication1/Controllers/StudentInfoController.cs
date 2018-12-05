using PagedList;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using WebApplication1;

namespace WebApplication1.Controllers
{
    public class StudentInfoController : Controller
    {
        private APTECHDBEntities db = new APTECHDBEntities();

        // GET: StudentInfo
        public ActionResult Index(int page = 1, int pageSize = 2)
        {
            List<STUDENTINFO> students = db.STUDENTINFOes.ToList();
            PagedList<STUDENTINFO> model = new PagedList<STUDENTINFO>(students, page, pageSize);

            return View(model);
        }

        // GET: StudentInfo/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            STUDENTINFO sTUDENTINFO = db.STUDENTINFOes.Find(id);
            if (sTUDENTINFO == null)
            {
                return HttpNotFound();
            }
            return View(sTUDENTINFO);
        }

        // GET: StudentInfo/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: StudentInfo/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,STD_ID,STD_NAME,STD_FNAME,STD_PIC,DOB,GENDER,PROG_NAME,BATCH_NO,TIME_SLOT,EMAIL_ID,PAR_EMAIL_ID,HOME_ADDRE,SEM_ID,ISSTC")] STUDENTINFO sTUDENTINFO)
        {
            if (ModelState.IsValid)
            {
                db.STUDENTINFOes.Add(sTUDENTINFO);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(sTUDENTINFO);
        }

        // GET: StudentInfo/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            STUDENTINFO sTUDENTINFO = db.STUDENTINFOes.Find(id);
            if (sTUDENTINFO == null)
            {
                return HttpNotFound();
            }
            return View(sTUDENTINFO);
        }

        // POST: StudentInfo/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,STD_ID,STD_NAME,STD_FNAME,STD_PIC,DOB,GENDER,PROG_NAME,BATCH_NO,TIME_SLOT,EMAIL_ID,PAR_EMAIL_ID,HOME_ADDRE,SEM_ID,ISSTC")] STUDENTINFO sTUDENTINFO)
        {
            if (ModelState.IsValid)
            {
                db.Entry(sTUDENTINFO).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(sTUDENTINFO);
        }

        // GET: StudentInfo/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            STUDENTINFO sTUDENTINFO = db.STUDENTINFOes.Find(id);
            if (sTUDENTINFO == null)
            {
                return HttpNotFound();
            }
            return View(sTUDENTINFO);
        }

        // POST: StudentInfo/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            STUDENTINFO sTUDENTINFO = db.STUDENTINFOes.Find(id);
            db.STUDENTINFOes.Remove(sTUDENTINFO);
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
