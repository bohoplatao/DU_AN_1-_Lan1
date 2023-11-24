using A_DAL.Context;
using A_DAL.IRepositories;
using A_DAL.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace A_DAL.Repositories
{
    public class LapTopRepos : ILapTop
    {
        private QL_LapTopContext _context;
        public LapTopRepos()
        {
            _context = new QL_LapTopContext();
        }
      

        public bool CreateLapTop(LapTop lt)
        {
            _context.Add(lt);
            _context.SaveChanges();
            return true;
        }

       

        public bool DeleteLapTop(LapTop lt)
        {
            _context.Remove(lt);
            _context.SaveChanges();
            return true;
        }

        public List<LapTop> GetAllLapTop()
        {
            return _context.LapTops.ToList();
        }

        public List<LapTop> GetPhanLoaiLapTop(string name)
        {
            return _context.LapTops.Where(p => p.TenLaptop.Contains(name)).ToList();
        }
        public List<LapTop> GetLTByGia(int cannang)
        {
            return _context.LapTops.Where(p => p.CanNang.ToString().Contains(cannang.ToString())).ToList();
        }

        public bool UpdateLapTop(LapTop lt)
        {
            _context.Update(lt);
            _context.SaveChanges();
            return true;
        }
    }
}
