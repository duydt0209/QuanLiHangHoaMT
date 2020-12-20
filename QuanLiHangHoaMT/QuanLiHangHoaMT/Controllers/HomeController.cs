using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using QuanLiHangHoaMT.Models;
using System.Data.Sql;
using QuanLiHangHoaMT.Models.ViewModel;
using System.Data.Entity;

namespace QuanLiHangHoaMT.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            var hangHoas = db.HangHoas.Include(S => S.LoaiHH);
            return View(hangHoas.ToList());
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
       
        private LTQLDbContext db = new LTQLDbContext();
        public ActionResult DemoLinq()
        {
            List<UserViewModel> query = (from user in db.Users
                                         join role in db.Roles on user.RoleID equals role.RoleID
                                         select new UserViewModel // lay du lieu 
                                         {
                                             UserName = user.UserName,
                                             Password = user.Password,
                                             RoleID   = role.RoleID,
                                             RoleName = role.RoleName,
                                         }).ToList<UserViewModel>();
            return View(query);
        }
        public ActionResult LinqHH()
        {
            List<HangHoaVM> query = (from a in db.HangHoas
                                         join b in db.HoaDons on a.MaHangHoa equals b.MaHangHoa
                                         select new HangHoaVM // lay du lieu 
                                         {
                                             MaHangHoa = a.MaHangHoa,
                                             TenHangHoa = a.TenHangHoa,
                                             DonGia = a.DonGia,
                                             SoLuong = a.SoLuong,
                                             TenHoaDon = b.TenHoaDon,

                                         }).ToList<HangHoaVM>();
            return View(query);
        }

    }
}