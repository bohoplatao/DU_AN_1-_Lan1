using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A_DAL.Model
{
    [Table("HoaDonCT")]
    public class HoaDonCT
    {
        public int MaHoaDonChiTiet { get; set; }
        //public int MaLaptopChiTiet { get; set; }
        public int MaHoaDon { get; set; }
        public int MaDanhGia { get; set; }
        public virtual DanhGia DanhGia { get; set; }    
        public int SoLuongNhap { get; set; }
        public int SoLuongXuat { get; set; }
        public int MaSerial { get; set; }
        public float Gia { get; set; }
        //public virtual LapTopCT LapTopCT { get; set; }
        public virtual HoaDon HoaDon { get; set; }
        public virtual Serial Serial { get; set; }
        // Khai báo khóa phụ
        //public LapTopCT LaptopCT { get; set; }
        //public HoaDon HoaDon { get; set; }
        //public DanhGia DanhGia { get; set; }
    }
}
