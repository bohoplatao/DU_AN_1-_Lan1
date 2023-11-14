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
    public class DangNhapRepos : IDangNhap
    {
        QL_LapTopContext _context = new QL_LapTopContext();
        public DangNhapRepos()
        {

        }
        public IEnumerable<NhanVien> GetTaikhoans()
        {
            throw new NotImplementedException();
        }

        public List<NhanVien> GetTaikhoans(string username)
        {
            throw new NotImplementedException();
        }
        public List<NhanVien> GetOne()
        {
            return _context.NhanViens.ToList();

        }
    }
    }
