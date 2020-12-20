using QuanLiHangHoaMT.Models;
using QuanLiHangHoaMT.Models.Process;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using System.Data.Entity;

namespace QuanLiHangHoaMT.Controllers
{
    public class AccountController : Controller
    {
        LTQLDbContext db = new LTQLDbContext();
        // GET: Account
        public ActionResult Index()
        {
            return View();
        }
      
        public ActionResult Create()
        {
            ViewBag.ListRole = db.Roles.ToList();
            return View();
        }
        public ActionResult Register()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Register(User us)
        {
            if (ModelState.IsValid)
            {
                var CheckUserName = db.Users.FirstOrDefault(m => m.UserName == us.UserName);
                if (CheckUserName==null)
                {
                    us.Password = GetMD5(us.Password);
                    db.Configuration.ValidateOnSaveEnabled = false;
                    db.Users.Add(us);
                    db.SaveChanges();
                    return RedirectToAction("Login");
                }
                else
                {
                    ViewBag.UserNameError = "Tên đăng nhập đã tồn tại";
                    return RedirectToAction("Register");
                }
            }
            return View();
        }
        public static string GetMD5(string strInput)
        {
            MD5 md5 = new MD5CryptoServiceProvider();
            byte[] fromData = Encoding.UTF8.GetBytes(strInput);
            byte[] targetData = md5.ComputeHash(fromData);
            string byte2String = null;

            for (int i = 0; i < targetData.Length; i++)
            {
                byte2String += targetData[i].ToString("x2");

            }
            return byte2String;
        }

        //public string GetMD5(string password)
        //{
        //    throw new NotImplementedException();
        //}

        public ActionResult Logout()
        {
            FormsAuthentication.SignOut();
            Session["idUser"] = null;
            return RedirectToAction("Login", "Account");
        }
        [AllowAnonymous]
        //returnUrl la gia tri copy r paste ( la cai paste )
        public ActionResult Login(string returnUrl)
        {
            if (CheckSession() == 1)
            {
                return RedirectToAction("Index", "Home_Ad", new { Area = "Admins" });
            }
            else if (CheckSession() == 2)
            {
                return RedirectToAction("Index", "Home_Le", new { Area = "Lectures" });
            }
            ViewBag.ReturnUrl = returnUrl;
            return View();
        }
        [AllowAnonymous]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Login(User acc, string returnUrl)
        {
            Stringprocess strPro = new Stringprocess();
            if (ModelState.IsValid) //ràng buộc ở model.(Required)
            try
            {
                if (!string.IsNullOrEmpty(acc.UserName) && !string.IsNullOrEmpty(acc.Password))
                {
                    using (var db = new LTQLDbContext())
                    {
                            var passToMD5 = GetMD5(acc.Password);
                            var account = db.Users.Where(m => m.UserName.Equals(acc.UserName) && m.Password.Equals(passToMD5)).Count();
                        if (account ==1)// check tkhoan mk trong sql để đăng nhập 
                        {
                            FormsAuthentication.SetAuthCookie(acc.UserName, false);
                            Session["idUser"] = acc.UserName;
                            Session["roleUser"] = acc.RoleID;
                            Response.Cookies.Add(new HttpCookie("userCookie", acc.UserName));
                            Response.Cookies.Add(new HttpCookie("roleCookie", acc.RoleID));
                            return RedirectToAction("Index");

                            }
                        ModelState.AddModelError("", "Thông tin đăng nhập chưa chính xác");
                    }
                }
                ModelState.AddModelError("", "Username and password is required.");
                }
                catch
                {
                    ModelState.AddModelError("", "Hệ thống đang được bảo trì, vui lòng liên hệ với quản trị viên");
                }
            return View(acc);
                }
        private ActionResult RedirectTolocal(string returnUrl)
        {
            if (string.IsNullOrEmpty(returnUrl) || returnUrl == "/")
            {
                if (CheckSession() == 1)
                {
                    return RedirectToAction("Index", "Home_Ad", new { Area = "Admins" });
                }
                else if (CheckSession() == 2)
                {
                    return RedirectToAction("Index", "Home_Le", new { Area = "Lectures" });
                }
            }
            if (Url.IsLocalUrl(returnUrl))
            {
                return Redirect(returnUrl);
            }
            else
            {
                return RedirectToAction("Index", "Home_Ad");
            }
        }
        private int CheckSession()
        {
            using (var db = new LTQLDbContext())
            {
                var user = HttpContext.Session["idUser"];
                if (user != null)
                {
                    var role = db.Users.Find(user.ToString()).RoleID;
                    if (role != null)
                    {
                        if (role.ToString() == "Admin")
                        {
                            return 1;
                        }
                        else if (role.ToString() == "Lecture")
                        {
                            return 2;
                        }
                    }
                }
            }
            return 0;
        }
    }
}