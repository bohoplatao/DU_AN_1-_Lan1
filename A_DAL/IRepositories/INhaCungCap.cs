using A_DAL.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A_DAL.IRepositories
{
    public interface INhaCungCap
    {
        public List<NhaCungCap> GetAllNCC(string name);
        List<NhaCungCap> GetNCCByName(string name);

        public bool CreateNCC(NhaCungCap ncc);
        public bool UpdateNCC(NhaCungCap ncc);
        public bool DeleteNCC(NhaCungCap ncc);
    }
}
