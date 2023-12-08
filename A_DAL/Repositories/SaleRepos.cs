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
    public class SaleRepos : ISale
    {
        private QL_LapTopContext _context;
        public SaleRepos()
        {
            _context = new QL_LapTopContext();
        }

        public bool CreateSALE(Sale s)
        {
            _context.Add(s);
            _context.SaveChanges();
            return true;
        }

        public bool DeleteSALE(Sale s)
        {
            _context.Remove(s);
            _context.SaveChanges();
            return true;
        }

        public List<Sale> GetAllSALE()
        {
            return _context.Sales.ToList();
        }

        public List<Sale> GetSALE()
        {
            return _context.Sales.ToList();
        }

        public bool UpdateSALE(Sale s)
        {
            _context.Update(s);
            _context.SaveChanges();
            return true;
        }
    }
}
