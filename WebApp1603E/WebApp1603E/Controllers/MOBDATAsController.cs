using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using WebApp1603E.Models;

namespace WebApp1603E.Controllers
{
    public class MOBDATAsController : Controller
    {
        private mobiledbEntities db = new mobiledbEntities();

        // GET: MOBDATAs
        public ActionResult Index()
        {
            var mOBDATAs = db.MOBDATAs.Include(m => m.MOBILBRAND);
            return View(mOBDATAs.ToList());
        }

        // GET: MOBDATAs/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            MOBDATA mOBDATA = db.MOBDATAs.Find(id);
            if (mOBDATA == null)
            {
                return HttpNotFound();
            }
            return View(mOBDATA);
        }

        // GET: MOBDATAs/Create
        public ActionResult Create()
        {
            ViewBag.BRAND_ID = new SelectList(db.MOBILBRANDS, "BRAND_ID", "BRANDNAME");
            return View();
        }

        // POST: MOBDATAs/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,BRAND_ID,MNAME,DES_MOBILE,PRICE,IMG")] MOBDATA mOBDATA)
        {
            if (ModelState.IsValid)
            {
                db.MOBDATAs.Add(mOBDATA);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.BRAND_ID = new SelectList(db.MOBILBRANDS, "BRAND_ID", "BRANDNAME", mOBDATA.BRAND_ID);
            return View(mOBDATA);
        }

        // GET: MOBDATAs/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            MOBDATA mOBDATA = db.MOBDATAs.Find(id);
            if (mOBDATA == null)
            {
                return HttpNotFound();
            }
            ViewBag.BRAND_ID = new SelectList(db.MOBILBRANDS, "BRAND_ID", "BRANDNAME", mOBDATA.BRAND_ID);
            return View(mOBDATA);
        }

        // POST: MOBDATAs/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,BRAND_ID,MNAME,DES_MOBILE,PRICE,IMG")] MOBDATA mOBDATA)
        {
            if (ModelState.IsValid)
            {
                db.Entry(mOBDATA).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.BRAND_ID = new SelectList(db.MOBILBRANDS, "BRAND_ID", "BRANDNAME", mOBDATA.BRAND_ID);
            return View(mOBDATA);
        }

        // GET: MOBDATAs/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            MOBDATA mOBDATA = db.MOBDATAs.Find(id);
            if (mOBDATA == null)
            {
                return HttpNotFound();
            }
            return View(mOBDATA);
        }

        // POST: MOBDATAs/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            MOBDATA mOBDATA = db.MOBDATAs.Find(id);
            db.MOBDATAs.Remove(mOBDATA);
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
