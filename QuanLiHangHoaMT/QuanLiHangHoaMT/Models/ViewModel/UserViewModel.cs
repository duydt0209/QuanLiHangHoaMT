using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace QuanLiHangHoaMT.Models.ViewModel
{
    public class UserViewModel
    {
        //lay ra 4 truong du lieu nay
        public string UserName { get; set; }
        public string Password { get; set; }
        public string RoleID { get; set; }
        public string RoleName { get; set; }
    }
}