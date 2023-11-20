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

       

        public List<NhanVien> GetAllNhanVien(string name)
        {
            return _context.NhanViens.ToList();
        }

        public List<NhanVien> GetNhanVienByName(string name)
        {
            throw new NotImplementedException();
        }

        public bool UpdateNhanVien(NhanVien nv)
        {
            _context.Update(nv);
            _context.SaveChanges();
            return true;
        }

       
    }
}
