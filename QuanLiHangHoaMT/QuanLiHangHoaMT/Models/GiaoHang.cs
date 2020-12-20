using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace QuanLiHangHoaMT.Models
{
    [Table("GiaoHangs")]
    public class GiaoHang
    {
        [Key]
        public string MaGH { get; set; }
        public string PhuongTienGH { get; set; }
        public string GiaGH { get; set; }

    }
}