using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.Intrinsics.Arm;
using System.Text;
using System.Threading.Tasks;

namespace A_DAL.Model
{
    [Table("LapTopCT")]
    public class LapTopCT
    {
        public int MaLaptopChiTiet { get; set; }
        public int MaLoaiHang { get; set; }
        public virtual LoaiHang LoaiHang { get; set; }
        public int MaPin { get; set; }
        public virtual Pin Pin { get; set; }
        public int MaPhanLoai { get; set; }
        public virtual PhanLoai PhanLoai { get; set; }
        public int MaChip { get; set; }
        public virtual Chip Chip { get; set; }
        public int MaRAM { get; set; }
        public virtual Ram Ram { get;set; }
        public int MaCardDoHoa { get; set; }
        public virtual CardDoHoa CardDoHoa { get; set; }
        public int MaLaptop { get; set; }
        public virtual LapTop LapTop { get; set; }
        public int MaManHinh { get; set; }
        public virtual ManHinh ManHinh { get; set; }    
        public int MaOCung { get; set; }
        public virtual OCung Ocung { get; set; }
        public int MaHinhAnh { get; set; }
        public virtual HinhAnh HinhAnh { get; set; }
        public float GiaBanDau { get; set; }
        public float GiaBan { get; set; }

        // Khai báo khóa phụ
        //public LoaiHang LoaiHang { get; set; }
        //public Pin Pin { get; set; }
        //public PhanLoai PhanLoai { get; set; }
        //public Chip Chip { get; set; }
        //public Ram RAM { get; set; }
        //public CardDoHoa CardDoHoa { get; set; }
        //public LapTop Laptop { get; set; }
        //public ManHinh ManHinh { get; set; }
        //public OCung OCung { get; set; }
        //public HinhAnh HinhAnh { get; set; }
        
        
        public virtual List<SaleCT> SaleCTs { get; set; }
      
        public virtual List<HoaDonCT> hoaDonCTs { get; set; }
    }
}
