using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace QuanLiHangHoaMT.Models
{
    public partial class Role
    {
        [Key]
        [StringLength(20)]
        public string RoleID { get; set; }
        public string RoleName { get; set; }
    }
}