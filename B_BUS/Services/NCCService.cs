using A_DAL.Model;
using A_DAL.Repositories;
using B_BUS.IServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B_BUS.Services
{
    public class NCCService : INCCService
    {
        private NCCRepos _repos;
        public NCCService()
        {
            _repos = new NCCRepos();
        }
        public string Add(NhaCungCap ncc)
        {
            if (_repos.CreateNCC(ncc) == true)
            {
                return "Them Thanh Cong";
            }
            else
            {
                return "Them that bai";
            }
        }

        public List<NhaCungCap> GetAll(string search)
        {
            if (search == null)
            {
                return _repos.GetAllNCC(null).ToList();
            }
            else
            {
                return _repos.GetAllNCC(null).Where(x => x.TenNCC.Contains(search)).ToList();
            }
        }

        

        public string Remove(NhaCungCap ncc)
        {
            var clone = _repos.GetAllNCC(null).FirstOrDefault(x => x.MaNCC == ncc.MaNCC);
            if (_repos.DeleteNCC(clone) == true)
            {
                return "Xoa Thanh Cong";
            }
            else
            {
                return "Xoa that bai";
            }
        }

        public string Update(NhaCungCap ncc)
        {
            var clone = _repos.GetAllNCC(null).FirstOrDefault(x => x.MaNCC == ncc.MaNCC);
            //clone.MaNCC = ncc.MaNCC;
            clone.TenNCC = ncc.TenNCC;
            clone.DiaChi = ncc.DiaChi;
           
            if (_repos.UpdateNCC(clone) == true)
            {
                return "Sua Thanh Cong";
            }
            else
            {
                return "Sua that bai";
            }
        }
    }
}
