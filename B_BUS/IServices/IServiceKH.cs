using A_DAL.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B_BUS.IServices
{
    internal interface IServiceKH
    {
        public string Add(KhachHang kh);
        public string Remove(KhachHang kh);
        public string Update(KhachHang kh);
        public List<KhachHang> GetAll(string search);
    }
}
