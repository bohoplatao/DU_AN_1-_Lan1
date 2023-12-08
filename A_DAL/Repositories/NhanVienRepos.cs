using A_DAL.Context;
using A_DAL.IRepositories;
using A_DAL.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A_DAL.Repositories
{
    public class NhanVienRepos : INhanVien
    {
        private QL_LapTopContext _context;
        public NhanVienRepos()
        {
            _context = new QL_LapTopContext();
        }
        public bool CreateNhanVien(NhanVien nv)
        {
            _context.Add(nv);
                _context.SaveChanges();
            return true;
        }

        public bool DeleteNhanVien(NhanVien nv)
        {
            _context.Remove(nv);
            _context.SaveChanges();
            return true;
        }

       

        public List<NhanVien> GetAllNhanVien()
        {
            return _context.NhanViens.ToList();
        }

        public List<NhanVien> GetNhanVienByName(string name)
        {
            return _context.NhanViens.Where(p => p.TenNhanVien.Contains(name)  || p.DiaChi.Contains(name)).ToList();
        }
        public List<NhanVien> GetBySDT(decimal sdt)
        {
            string sdtString = sdt.ToString().Trim();
            return _context.NhanViens.Where(p => p.SoDienThoai.ToString().Contains(sdtString.ToString())).ToList();
        }

        public bool UpdateNhanVien(NhanVien nv)
        {
            _context.Update(nv);
            _context.SaveChanges();
            return true;
        }

        public List<NhanVien> GetAllNhanVien(string name)
        {
            throw new NotImplementedException();
        }

        public  bool ChangePassWord(int id, string pass, string newPass)
        {
            var nhanviem = _context.NhanViens.FirstOrDefault(x => x.MaNhanVien == id && x.MatKhau == pass);
            if(nhanviem != null)
            {
                nhanviem.MatKhau =newPass;
                _context.SaveChanges();
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
