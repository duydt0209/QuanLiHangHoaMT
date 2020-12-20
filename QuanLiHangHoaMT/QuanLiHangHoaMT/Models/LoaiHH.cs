using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace QuanLiHangHoaMT.Models
{
    [Table("LoaiHHs")]
    public class LoaiHH
    {
        public LoaiHH()
        {
            HangHoas = new HashSet<HangHoa>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public string MaLoaiHH { get; set; }
        public string TenLoaiSP { get; set; }
        public virtual ICollection<HangHoa> HangHoas { get; set; }
    }
}