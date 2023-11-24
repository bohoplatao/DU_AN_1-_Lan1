using A_DAL.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B_BUS.IServices
{
    internal interface IHoaDonCTService
    {
        public string Add(HoaDonCT hd);
        public string Remove(HoaDonCT hd);
        public string Update(HoaDonCT hd);
        public List<HoaDonCT> GetAll(string search);
    }
}
