using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A_DAL.Model
{
    [Table("LoaiHang")]
    public class LoaiHang
    {
        
        public int MaLoaiHang { get; set; }
        public int MaNhaCungCap { get; set; }
        
        public virtual NhaCungCap NhaCungCap { get; set; }
        public string TenLoaiHang { get; set; }

        // Khai báo khóa phụ
        //public NhaCungCap NhaCungCap { get; set; }
        
        public virtual ICollection<LapTopCT> LapTopCTs { get; set; }
    }
}
