using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A_DAL.Model
{
    [Table("NhanVien")]
    public class NhanVien
    {
        [Key]
        public int MaNhanVien { get; set; }
        public string TenNhanVien { get; set; }
        public string DiaChi { get; set; }
        public string HinhAnh { get; set; }
        public decimal SoDienThoai { get; set; }
        public DateTime NgaySinh { get; set; }
        public string MatKhau { get; set; }
        public string Quyen { get; set; }
        public bool TrangThai { get; set; }

       
        public virtual ICollection<HoaDon> HoaDons { get; set; }

        
        public virtual ICollection<LapTop> LapTops { get; set; }
        
        public virtual ICollection<Sale> Sales { get; set; }
    }
}
