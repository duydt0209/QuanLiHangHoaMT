﻿using System.Web.Mvc;

namespace QuanLiHangHoaMT.Areas.Admins
{
    public class AdminsAreaRegistration : AreaRegistration 
    {
        public override string AreaName 
        {
            get 
            {
                return "Admins";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context) 
        {
            context.MapRoute(
                "Admins_default",
                "Admins/{controller}/{action}/{id}",
                new { action = "Index", id = UrlParameter.Optional },
                new[] { "QuanLiHangHoaMT.Areas.Admins.Controllers" }
            ); 
        }
    }
}