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
    public class HoaDonRepos :IHoaDon
    {
        private QL_LapTopContext _context;
        public HoaDonRepos()
        {
               _context = new QL_LapTopContext();
        }

        public bool CreateHoaDon(HoaDon hd)
        {
            _context.Add(hd);
            _context.SaveChanges();
            return true;
        }

        public bool DeleteHoaDon(HoaDon hd)
        {
            _context.Remove(hd);
            _context.SaveChanges();
            return true;
        }

        public List<HoaDon> GetAllHoaDon()
        {
            return _context.HoaDons.ToList();
        }

        public bool UpdateHoaDon(HoaDon hd)
        {
            _context.Update(hd);
            _context.SaveChanges();
            return true;
        }
    }
}
