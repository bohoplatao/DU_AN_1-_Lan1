using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A_DAL.Model
{
    [Table("DanhGia")]
    public class DanhGia
    {
        [Key]
        public int MaDanhGia { get; set; }
        
        public string NoiDung { get; set; }
        public DateTime ThoiGian { get; set; }
        public int DanhGias { get; set; }
        
        public virtual ICollection<HoaDonCT> HoaDonCTs { get; set; }
    }
}
