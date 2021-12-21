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
    public class NMDSinhVien392Controller : Controller
    {
        private DataDBContext db = new DataDBContext();

        // GET: NMDSinhVien392
        public ActionResult Index()
        {
            return View(db.NMDSinhVien392.ToList());
        }

        // GET: NMDSinhVien392/Details/5
        public ActionResult Details(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            NMDSinhVien392 nMDSinhVien392 = db.NMDSinhVien392.Find(id);
            if (nMDSinhVien392 == null)
            {
                return HttpNotFound();
            }
            return View(nMDSinhVien392);
        }

        // GET: NMDSinhVien392/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: NMDSinhVien392/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "MaSinhVien,HoTen,MaLop")] NMDSinhVien392 nMDSinhVien392)
        {
            if (ModelState.IsValid)
            {
                db.NMDSinhVien392.Add(nMDSinhVien392);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(nMDSinhVien392);
        }

        // GET: NMDSinhVien392/Edit/5
        public ActionResult Edit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            NMDSinhVien392 nMDSinhVien392 = db.NMDSinhVien392.Find(id);
            if (nMDSinhVien392 == null)
            {
                return HttpNotFound();
            }
            return View(nMDSinhVien392);
        }

        // POST: NMDSinhVien392/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "MaSinhVien,HoTen,MaLop")] NMDSinhVien392 nMDSinhVien392)
        {
            if (ModelState.IsValid)
            {
                db.Entry(nMDSinhVien392).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(nMDSinhVien392);
        }

        // GET: NMDSinhVien392/Delete/5
        public ActionResult Delete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            NMDSinhVien392 nMDSinhVien392 = db.NMDSinhVien392.Find(id);
            if (nMDSinhVien392 == null)
            {
                return HttpNotFound();
            }
            return View(nMDSinhVien392);
        }

        // POST: NMDSinhVien392/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            NMDSinhVien392 nMDSinhVien392 = db.NMDSinhVien392.Find(id);
            db.NMDSinhVien392.Remove(nMDSinhVien392);
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
