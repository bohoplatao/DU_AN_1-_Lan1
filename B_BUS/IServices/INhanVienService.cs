using A_DAL.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B_BUS.IServices
{
    internal interface INhanVienService
    {
        public string Add(NhanVien nv);
        public string Remove(NhanVien nv);
        public string Update(NhanVien nv);
        public List<NhanVien> GetAll(string search);
    }
}
