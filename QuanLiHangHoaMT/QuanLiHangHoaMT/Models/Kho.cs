using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace QuanLiHangHoaMT.Models
{
    [Table("Khos")]
    public class Kho
    {
        [Key]
        public string MaKho { get; set; }
        public string TenKho { get; set; }
        public string TinhTrangKho { get; set; }

    }
}