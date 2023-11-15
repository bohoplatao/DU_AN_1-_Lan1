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
    
    
    public class TheLoaiRepos : ITheLoai
    {
        private QL_LapTopContext _context;
        public TheLoaiRepos()
        {
            _context = new QL_LapTopContext();
        }
        public bool CreatePhanLoai(PhanLoai pl)
        {
            _context.Add(pl);
            _context.SaveChanges();
            return true;
        }

        public bool DeletePhanLoai(PhanLoai pl)
        {
            _context.Remove(pl);
            _context.SaveChanges();
            return true;
        }

        public List<PhanLoai> GetAllPhanLoai(string name)
        {
            return _context.PhanLoais.ToList();
        }

        public List<PhanLoai> GetPhanLoaiByName(string name)
        {
            throw new NotImplementedException();
        }

        public bool UpdatePhanLoai(PhanLoai pl)
        {
            _context.Update(pl);
            _context.SaveChanges();
            return true;
        }
    }
}
