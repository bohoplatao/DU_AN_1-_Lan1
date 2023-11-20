using A_DAL.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A_DAL.IRepositories
{
    public interface IKhachHang
    {
        public List<KhachHang> GetAllKH(string name);
        List<KhachHang> GetKHByName(string name);

        public bool CreateKH(KhachHang kh);
        public bool UpdateKH(KhachHang kh);
        public bool DeleteKH(KhachHang kh);
    }
}
