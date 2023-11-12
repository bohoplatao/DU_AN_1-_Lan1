using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A_DAL.Model
{
    [Table("DiemThuong")]
    public class DiemThuong
    {
        [Key]
        public int MaDiemThuong { get; set; }
      
        public DateTime NgayTao { get; set; }
        public int DiemCong { get; set; }
        public string TrangThai { get; set; }

        
        public virtual ICollection<HoaDon> HoaDon { get; set; }

    }
}

