using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A_DAL.Model
{
    [Table("HinhAnh")]
    public class HinhAnh
    {
        [Key]
        public int MaHinhAnh { get; set; }
       
        public string Src { get; set; }
        public int MaNguoiTao { get; set; }
        public DateTime NgayTao { get; set; }
        
        public virtual ICollection<LapTopCT> LapTopCT { get; set; }
    }
}
