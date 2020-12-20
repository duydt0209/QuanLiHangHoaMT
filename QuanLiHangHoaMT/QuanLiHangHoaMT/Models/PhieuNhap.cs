using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace QuanLiHangHoaMT.Models
{
    [Table("PhieuNhaps")]
    public class PhieuNhap
    {
        [Key]
        public string MaNhap { get; set; }
        public string TenPhieuNhap { get; set; }
        public string NgayNhap { get; set; }
        public string SoLuongNhap { get; set; }
        public string GiaNhap { get; set; }
        public string MaNhanVien { get; set; }
        public string MaNCC { get; set; }
        public string MaHangHoa { get; set; }


    }
}