using A_DAL.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A_DAL.IRepositories
{
    public interface INhanVien
    {
        public List<NhanVien> GetAllNhanVien(string name);
        List<NhanVien> GetNhanVienByName(string name);
        List<NhanVien> GetBySDT(decimal sdt);

        public bool CreateNhanVien(NhanVien nv);
        public bool UpdateNhanVien(NhanVien nv);
        public bool DeleteNhanVien(NhanVien nv);
    }
}
