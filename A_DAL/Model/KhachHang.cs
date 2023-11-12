using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A_DAL.Model
{
    [Table("KhachHang")]
    public class KhachHang
    {
        [Key]
        public int MaKhachHang { get; set; }
        public string TenKhachHang { get; set; }
        public string DiaChi { get; set; }
        public string HinhAnh { get; set; }
        public decimal SoDienThoai { get; set; }
        public DateTime NgaySinh { get; set; }
        public bool TrangThai { get; set; }

      
        public virtual ICollection<HoaDon> HoaDon { get; set; }
    }
}

