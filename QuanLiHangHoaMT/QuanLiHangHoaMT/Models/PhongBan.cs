using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace QuanLiHangHoaMT.Models
{
    [Table("PhongBans")]
    public class PhongBan
    {
        [Key]
        public string MaPhongBan { get; set; }
        public string TenPhongBan { get; set; }
        public string SdtPB { get; set; }
        public string DiaChiPB { get; set; }
        public string MaNhanVien { get; set; }
    }
}