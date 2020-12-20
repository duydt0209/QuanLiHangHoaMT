using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace QuanLiHangHoaMT.Models
{
    [Table("NhaCungCaps")]
    public class NhaCungCap
    {
        [Key]
        public string MaNCC { get; set; }
        public string TenNCC { get; set; }
        public string DiaChiNCC { get; set; }
        public string SoDT { get; set; }
        public string Website { get; set; }
    }
}