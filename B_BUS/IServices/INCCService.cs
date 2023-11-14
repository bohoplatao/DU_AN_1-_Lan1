using A_DAL.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B_BUS.IServices
{
    internal interface INCCService
    {
        public string Add(NhaCungCap ncc);
        public string Remove(NhaCungCap ncc);
        public string Update(NhaCungCap ncc);
        public List<NhaCungCap> GetAll(string search);
    }
}
