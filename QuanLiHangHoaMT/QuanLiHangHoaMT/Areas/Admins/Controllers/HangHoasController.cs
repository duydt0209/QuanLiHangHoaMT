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
    public class HangHoasController : Controller
    {
        private LTQLDbContext db = new LTQLDbContext();

        // GET: Admins/HangHoas
        public ActionResult Index()
        {
            var hangHoas = db.HangHoas.Include(h => h.LoaiHH);
            return View(hangHoas.ToList());
        }

        // GET: Admins/HangHoas/Details/5
        public ActionResult Details(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            HangHoa hangHoa = db.HangHoas.Find(id);
            if (hangHoa == null)
            {
                return HttpNotFound();
            }
            return View(hangHoa);
        }

        // GET: Admins/HangHoas/Create
        public ActionResult Create()
        {
            ViewBag.MaLoaiHH = new SelectList(db.LoaiHHs, "MaLoaiHH", "TenLoaiSP");
            return View();
        }

        // POST: Admins/HangHoas/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "MaHangHoa,TenHangHoa,DonGia,SoLuong,MaLoaiHH,HinhHH")] HangHoa hangHoa)
        {
            if (ModelState.IsValid)
            {
                db.HangHoas.Add(hangHoa);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.MaLoaiHH = new SelectList(db.LoaiHHs, "MaLoaiHH", "TenLoaiSP", hangHoa.MaLoaiHH);
            return View(hangHoa);
        }

        // GET: Admins/HangHoas/Edit/5
        public ActionResult Edit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            HangHoa hangHoa = db.HangHoas.Find(id);
            if (hangHoa == null)
            {
                return HttpNotFound();
            }
            ViewBag.MaLoaiHH = new SelectList(db.LoaiHHs, "MaLoaiHH", "TenLoaiSP", hangHoa.MaLoaiHH);
            return View(hangHoa);
        }

        // POST: Admins/HangHoas/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "MaHangHoa,TenHangHoa,DonGia,SoLuong,MaLoaiHH,HinhHH")] HangHoa hangHoa)
        {
            if (ModelState.IsValid)
            {
                db.Entry(hangHoa).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.MaLoaiHH = new SelectList(db.LoaiHHs, "MaLoaiHH", "TenLoaiSP", hangHoa.MaLoaiHH);
            return View(hangHoa);
        }

        // GET: Admins/HangHoas/Delete/5
        public ActionResult Delete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            HangHoa hangHoa = db.HangHoas.Find(id);
            if (hangHoa == null)
            {
                return HttpNotFound();
            }
            return View(hangHoa);
        }

        // POST: Admins/HangHoas/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            HangHoa hangHoa = db.HangHoas.Find(id);
            db.HangHoas.Remove(hangHoa);
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
