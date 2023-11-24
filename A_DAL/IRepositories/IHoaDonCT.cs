using A_DAL.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A_DAL.IRepositories
{
    public interface IHoaDonCT
    {
        public List<HoaDonCT> GetHoaDonCTs();
        public bool CreateHoaDonCT(HoaDonCT hd);
        public bool UpdateHoaDonCT(HoaDonCT hd);
        public bool DeleteHoaDonCT(HoaDonCT hd);
    }
}
