using A_DAL.Context;
using A_DAL.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A_DAL.Repositories
{
    public class LapTopCTRepos
    {
        private QL_LapTopContext _context;
        //public PhuHuynhRepos()
        //{
        //    _context = new SOF205_FINAL_TESTContext();
        //}
        public LapTopCTRepos()
        {
            _context = new QL_LapTopContext();
        }
        public List<LapTopCT> GetLTCT()
        {
            return _context.LapTopCTs.ToList();
        }
    }
}
