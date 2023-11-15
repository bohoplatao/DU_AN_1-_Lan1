using A_DAL.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B_BUS.IServices
{
    internal interface IPhanLoaiService
    {
        public string Add(PhanLoai pl);
        public string Remove(PhanLoai pl);
        public string Update(PhanLoai pl);
        public List<PhanLoai> GetAll(string search);
    }
}
