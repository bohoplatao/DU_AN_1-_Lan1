using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A_DAL.Model
{
    [Table("NhaCungCap")]
    public class NhaCungCap
    {
        [Key]
        public int MaNCC { get; set; }
        public string TenNCC { get; set; }
        public string DiaChi { get; set; }
       
        public virtual ICollection<LoaiHang> LoaiHang { get; set; }
    }
}
