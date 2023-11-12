using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A_DAL.Model
{
    [Table("SaleCT")]
    public class SaleCT
    {
        
        public int MaSaleChiTiet { get; set; }
        public int MaSale { get; set; }
        public virtual Sale Sale { get; set; }
        public int MaLaptopChiTiet { get; set; }
        public virtual LapTopCT LapTopCT { get; set; }
        public decimal GiaTriGiamGia { get; set; }
        public int SoLuongApDung { get; set; }

        // Khai báo khóa phụ
        //public Sale Sale { get; set; }
        //public LapTopCT LaptopChiTiet { get; set; }
    }
}
