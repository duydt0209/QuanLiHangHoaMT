using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace QuanLiHangHoaMT.Models
{
    [Table("KhachHangs")]
    public class KhachHang
    {
        [Key]
        public string MaKhachHang { get; set; }
        public string TenKhachHang { get; set; }
        public string SoDT { get; set; }
        public string DiaChiKH { get; set; }
        public string NgaySinh { get; set; }
    }
}