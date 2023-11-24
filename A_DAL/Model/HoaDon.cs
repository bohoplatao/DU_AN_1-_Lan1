using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A_DAL.Model
{
    [Table("HoaDon")]
    public class HoaDon
    {
       
        public int MaHoaDon { get; set; }
        

        public int MaKhachHang { get; set; }
       
        public virtual KhachHang KhachHang { get; set; }
        public int MaNhanVien { get; set; }
        
        public virtual NhanVien NhanVien { get; set; }
        public int MaDiemThuong { get; set; }
        
        public virtual DiemThuong DiemThuong { get; set; }
        public string TenNguoiNhan { get; set; }
        public string DiaChi { get; set; }
        public decimal SoDienThoai { get; set; }
        public DateTime NgayMua { get; set; }
        public float TongTien { get; set; }
        public string ChuThich { get; set; }
        public int TrangThai { get; set; }

        //Khai báo khóa phụ
        //public KhachHang KhachHang { get; set; }
        //public NhanVien NhanVien { get; set; }
        //public DiemThuong DiemThuong { get; set; }
        
        public virtual ICollection<HoaDonCT> HoaDonCTs { get; set; }

    }
}
