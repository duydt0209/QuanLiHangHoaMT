using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace QuanLiHangHoaMT.Models
{
    [Table("HangHoas")]
    public class HangHoa
    {
        [Key]
        public string MaHangHoa { get; set; }
        public string TenHangHoa { get; set; }
        public string DonGia { get; set; }
        public string SoLuong { get; set; }
        public string MaLoaiHH { get; set; }
        public string HinhHH { get; set; }
        public virtual LoaiHH LoaiHH { get; set; }
    }
}