using A_DAL.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B_BUS.IServices
{
    internal interface ILapTopService
    {
        public string Add(LapTop lt);
        public string Remove(LapTop lt);
        public string Update(LapTop lt);
        public List<LapTop > GetAll(string search);
    }
}
