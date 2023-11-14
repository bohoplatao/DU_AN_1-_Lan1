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
    public class NCCRepos : INhaCungCap
    {
        private QL_LapTopContext _context;
        public NCCRepos()
        {
            _context = new QL_LapTopContext();
        }

        public bool CreateNCC(NhaCungCap ncc)
        {
            _context.Add(ncc);
            _context.SaveChanges();
            return true;
        }

        public bool DeleteNCC(NhaCungCap ncc)
        {
            _context.Remove(ncc);
            _context.SaveChanges();
            return true;
        }

        public List<NhaCungCap> GetAllNCC(string name)
        {
            return _context.NhaCungCaps.ToList();
        }

        public List<NhaCungCap> GetNCCByName(string name)
        {
            throw new NotImplementedException();
        }

        public bool UpdateNCC(NhaCungCap ncc)
        {
            _context.Update(ncc);
            _context.SaveChanges();
            return true;
        }
    }
}
