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
    public class HoaDonCTRepos : IHoaDonCT
    {
        private QL_LapTopContext _context;
        public HoaDonCTRepos()
        {
            _context = new QL_LapTopContext();
        }

        public bool CreateHoaDonCT(HoaDonCT hd)
        {
            _context.Add(hd);
            _context.SaveChanges();
            return true;
        }

        public bool DeleteHoaDonCT(HoaDonCT hd)
        {
            _context.Remove(hd);
            _context.SaveChanges();
            return true;
        }

        public List<HoaDonCT> GetHoaDonCTs()
        {
            var x = _context.hoaDonCTs.ToList(); ;
            return x;
        }
        public List<HoaDonCT> GetHoaDonCT2()
        {
            var x = _context.hoaDonCTs.ToList(); ;
            return x;
        }
        public bool UpdateHoaDonCT(HoaDonCT hd)
        {
            _context.Update(hd);
            _context.SaveChanges();
            return true;
        }
    }
}
