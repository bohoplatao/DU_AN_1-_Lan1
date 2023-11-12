using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A_DAL.Model
{
    [Table("Sale")]
    public class Sale
    {
       
        public int MaSale { get; set; }
        public int MaNhanVien { get; set; }
    
        public virtual NhanVien NhanVien { get; set; }
        public string TenDotSale { get; set; }
        public DateTime ThoiGianBD { get; set; }
        public DateTime ThoiGianKT { get; set; }

        // Khai báo khóa phụ
        //public NhanVien NhanVien { get; set; }
        //public SaleCT SaleCT { get; set; }
        public virtual ICollection<SaleCT> SaleCT { get; set; }
    }
}
