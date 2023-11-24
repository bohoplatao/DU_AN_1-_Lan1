using A_DAL.Context;
using A_DAL.IRepositories;
using A_DAL.Model;
using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A_DAL.Repositories
{
    public class KhachHangRepos : IKhachHang
        
    {
        private QL_LapTopContext _context;
        public KhachHangRepos()
        {
            _context = new QL_LapTopContext();
        }
        public bool CreateKH(KhachHang kh)
        {
            _context.Add(kh);
            _context.SaveChanges();
            return true;
        }

        public bool DeleteKH(KhachHang kh)
        {
            _context.Remove(kh);
            _context.SaveChanges();
            return true;
        }

        public List<KhachHang> GetAllKH()
        {
            return _context.KhachHangs.ToList();
        }

        public List<KhachHang> GetKHByName(string name)
        {
            return _context.KhachHangs.Where(p => p.TenKhachHang.Contains(name)).ToList();
        }
        public List<KhachHang> GetKHBySDT(decimal sdt)
        {
            string sdtString = sdt.ToString().Trim();
            return _context.KhachHangs.Where(p => p.SoDienThoai.ToString().Contains(sdtString.ToString())).ToList();
        }



        public bool UpdateKH(KhachHang kh)
        {
            _context.Update(kh);
            _context.SaveChanges();
            return true;
        }

    
    }
}
