using A_DAL.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A_DAL.ViewModels
{
    public class NhanVienWithSale
    {

        public int MaSale { get; set; }
        public int MaNhanVien { get; set; }

        public virtual NhanVien NhanVien { get; set; }
        public string TenDotSale { get; set; }
        public DateTime ThoiGianBD { get; set; }
        public DateTime ThoiGianKT { get; set; }    
        public string TenNhanVien { get; set; }       
        public decimal SoDienThoai { get; set; }

    }
}
