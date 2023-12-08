using A_DAL.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A_DAL.IRepositories
{
    public interface ISale
    {
        public List<Sale> GetAllSALE();
        //List<HoaDon> GetNhanVienByName(string name);
        //List<NhanVien> GetBySDT(decimal sdt);

        public bool CreateSALE(Sale s);
        public bool UpdateSALE(Sale s);
        public bool DeleteSALE(Sale s);

    }
}
