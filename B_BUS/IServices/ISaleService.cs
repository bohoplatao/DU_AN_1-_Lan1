using A_DAL.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B_BUS.IServices
{
    internal interface ISaleService
    {
        public string Add(Sale s);
        public string Remove(Sale s);
        public string Update(Sale s);
        public List<Sale> GetAll(string search);
    }
}
