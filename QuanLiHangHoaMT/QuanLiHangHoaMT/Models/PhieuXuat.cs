using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace QuanLiHangHoaMT.Models
{
    [Table("PhieuXuats")]
    public class PhieuXuat
    {
        [Key]
        public string MaXuat { get; set; }
        public string TenPhieuXuat { get; set; }
        public string NgayXuat { get; set; }
        public string SoLuongXuat { get; set; }
        public string GiaXuat { get; set; }
        public string MaNhanVien { get; set; }
        public string MaKhachHang { get; set; }
        public string MaHangHoa { get; set; }


    }
}