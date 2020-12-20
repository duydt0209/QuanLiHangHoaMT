using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using QuanLiHangHoaMT.Models;

namespace QuanLiHangHoaMT.Areas.Admins.Controllers
{
    public class KhoesController : Controller
    {
        private LTQLDbContext db = new LTQLDbContext();

        // GET: Admins/Khoes
        public ActionResult Index()
        {
            return View(db.Khos.ToList());
        }

        // GET: Admins/Khoes/Details/5
        public ActionResult Details(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Kho kho = db.Khos.Find(id);
            if (kho == null)
            {
                return HttpNotFound();
            }
            return View(kho);
        }

        // GET: Admins/Khoes/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Admins/Khoes/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "MaKho,TenKho,TinhTrangKho")] Kho kho)
        {
            if (ModelState.IsValid)
            {
                db.Khos.Add(kho);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(kho);
        }

        // GET: Admins/Khoes/Edit/5
        public ActionResult Edit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Kho kho = db.Khos.Find(id);
            if (kho == null)
            {
                return HttpNotFound();
            }
            return View(kho);
        }

        // POST: Admins/Khoes/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "MaKho,TenKho,TinhTrangKho")] Kho kho)
        {
            if (ModelState.IsValid)
            {
                db.Entry(kho).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(kho);
        }

        // GET: Admins/Khoes/Delete/5
        public ActionResult Delete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Kho kho = db.Khos.Find(id);
            if (kho == null)
            {
                return HttpNotFound();
            }
            return View(kho);
        }

        // POST: Admins/Khoes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            Kho kho = db.Khos.Find(id);
            db.Khos.Remove(kho);
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
