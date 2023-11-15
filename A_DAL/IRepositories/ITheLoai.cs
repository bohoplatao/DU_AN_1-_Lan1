using A_DAL.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A_DAL.IRepositories
{
    public interface ITheLoai
    {
        public List<PhanLoai> GetAllPhanLoai(string name);
        List<PhanLoai> GetPhanLoaiByName(string name);

        public bool CreatePhanLoai(PhanLoai pl);
        public bool UpdatePhanLoai(PhanLoai pl);
        public bool DeletePhanLoai(PhanLoai pl);
    }
}
