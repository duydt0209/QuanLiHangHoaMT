using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace QuanLiHangHoaMT.Models
{
    [Table("NhanViens")]
    public class NhanVien
    {
        [Key]
        public string MaNhanVien { get; set; }
        public string TenNhanVien { get; set; }
        public string NgaySinhNV { get; set; }
        public string DiaChiNV { get; set; }
        public string QueQuanNV { get; set; }
        public string SoDT { get; set; }
    }
}