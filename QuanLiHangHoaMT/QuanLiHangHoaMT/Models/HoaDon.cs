using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace QuanLiHangHoaMT.Models
{
    [Table("HoaDons")]
    public class HoaDon
    {
        [Key]
        public string MaHoaDon { get; set; }
        public string TenHoaDon { get; set; }
        public string ThanhTien { get; set; }
        public string SoLuong { get; set; }
        public string DonGia { get; set; }
        public string MaNhanVien { get; set; }
        public string MaKhachHang { get; set; }
        public string MaHangHoa { get; set; }
    }
}