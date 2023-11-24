using A_DAL.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A_DAL.IRepositories
{
    public interface IHoaDon
    {
        public List<HoaDon> GetAllHoaDon();
        //List<HoaDon> GetNhanVienByName(string name);
        //List<NhanVien> GetBySDT(decimal sdt);

        public bool CreateHoaDon(HoaDon hd);
        public bool UpdateHoaDon(HoaDon hd);
        public bool DeleteHoaDon(HoaDon hd);
    }
}
