using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using QuanLiHangHoaMT.Models;

namespace QuanLiHangHoaMT.Controllers
{
    public class LoaiHHsController : Controller
    {
        private LTQLDbContext db = new LTQLDbContext();

        // GET: LoaiHHs
        public ActionResult Index()
        {
            if (Session["idUser"] == null)
            {
                return RedirectToAction("Login", "Account");
            }
            return View(db.LoaiHHs.ToList());
        }

        // GET: LoaiHHs/Details/5
        public ActionResult Details(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            LoaiHH loaiHH = db.LoaiHHs.Find(id);
            if (loaiHH == null)
            {
                return HttpNotFound();
            }
            return View(loaiHH);
        }

        // GET: LoaiHHs/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: LoaiHHs/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "MaLoaiHH,TenLoaiSP")] LoaiHH loaiHH)
        {
            if (ModelState.IsValid)
            {
                db.LoaiHHs.Add(loaiHH);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(loaiHH);
        }

        // GET: LoaiHHs/Edit/5
        public ActionResult Edit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            LoaiHH loaiHH = db.LoaiHHs.Find(id);
            if (loaiHH == null)
            {
                return HttpNotFound();
            }
            return View(loaiHH);
        }

        // POST: LoaiHHs/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "MaLoaiHH,TenLoaiSP")] LoaiHH loaiHH)
        {
            if (ModelState.IsValid)
            {
                db.Entry(loaiHH).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(loaiHH);
        }

        // GET: LoaiHHs/Delete/5
        public ActionResult Delete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            LoaiHH loaiHH = db.LoaiHHs.Find(id);
            if (loaiHH == null)
            {
                return HttpNotFound();
            }
            return View(loaiHH);
        }

        // POST: LoaiHHs/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            LoaiHH loaiHH = db.LoaiHHs.Find(id);
            db.LoaiHHs.Remove(loaiHH);
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
