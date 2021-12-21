using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using LTQL_1721050392.Models;

namespace LTQL_1721050392.Controllers
{
    public class LopHoc392Controller : Controller
    {
        private DataDBContext db = new DataDBContext();

        // GET: LopHoc392
        public ActionResult Index()
        {
            return View(db.LopHoc392s.ToList());
        }

        // GET: LopHoc392/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            LopHoc392 lopHoc392 = db.LopHoc392s.Find(id);
            if (lopHoc392 == null)
            {
                return HttpNotFound();
            }
            return View(lopHoc392);
        }

        // GET: LopHoc392/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: LopHoc392/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "MaLop,TenLop")] LopHoc392 lopHoc392)
        {
            if (ModelState.IsValid)
            {
                db.LopHoc392s.Add(lopHoc392);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(lopHoc392);
        }

        // GET: LopHoc392/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            LopHoc392 lopHoc392 = db.LopHoc392s.Find(id);
            if (lopHoc392 == null)
            {
                return HttpNotFound();
            }
            return View(lopHoc392);
        }

        // POST: LopHoc392/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "MaLop,TenLop")] LopHoc392 lopHoc392)
        {
            if (ModelState.IsValid)
            {
                db.Entry(lopHoc392).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(lopHoc392);
        }

        // GET: LopHoc392/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            LopHoc392 lopHoc392 = db.LopHoc392s.Find(id);
            if (lopHoc392 == null)
            {
                return HttpNotFound();
            }
            return View(lopHoc392);
        }

        // POST: LopHoc392/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            LopHoc392 lopHoc392 = db.LopHoc392s.Find(id);
            db.LopHoc392s.Remove(lopHoc392);
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
