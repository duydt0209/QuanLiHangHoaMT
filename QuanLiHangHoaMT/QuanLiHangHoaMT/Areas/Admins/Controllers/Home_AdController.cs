using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace QuanLiHangHoaMT.Areas.Admins.Controllers
{
    public class Home_AdController : Controller
    {
        // GET: Admins/Home_Ad
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Logout()
        {
            FormsAuthentication.SignOut();
            Session["idUser"] = null;
            return RedirectToAction("Index", "Home_Ad");
        }
    }
}