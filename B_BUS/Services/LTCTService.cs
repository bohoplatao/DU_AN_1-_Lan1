using A_DAL.Context;
using A_DAL.Model;
using A_DAL.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B_BUS.Services
{
    public class LTCTService
    {
        private LapTopCTRepos _repos;
        public LTCTService()
        {
            _repos = new LapTopCTRepos();
        }
        public List<LapTopCT> GetAllPH()
        {
            return _repos.GetLTCT();
        }
    }
}
