using A_DAL.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A_DAL.IRepositories
{
    public interface IDangNhap
    {
        IEnumerable<NhanVien> GetTaikhoans();
        List<NhanVien> GetTaikhoans(string username);
    }
}
