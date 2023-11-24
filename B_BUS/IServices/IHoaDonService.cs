using A_DAL.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B_BUS.IServices
{
    internal interface IHoaDonService
    {
        public string Add(HoaDon hd);
        public string Remove(HoaDon hd);
        public string Update(HoaDon hd);
        public List<HoaDon > GetAll(string search);
    }
}
