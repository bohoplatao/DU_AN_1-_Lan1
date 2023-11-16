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
    public class LapTopSerVice : ILapTopService
    {
        private LapTopRepos _repos;
        
        private LapTopCTRepos _lapTopCTRepos;
        public LapTopSerVice()
        {
            _repos = new LapTopRepos();
            
            _lapTopCTRepos = new LapTopCTRepos();
        }
        public string Add(LapTop lt)
        {
            if (_repos.CreateLapTop(lt) == true)
            {
                return "Them Thanh Cong";
            }
            else
            {
                return "Them that bai";
            }
        }

        public List<LapTop> GetAll(string search)
        {
            if (search == null)
            {
                return _repos.GetAllLapTop(null).ToList();
            }
            else
            {
                return _repos.GetAllLapTop(null).Where(x => x.TenLaptop.Contains(search)).ToList();
            }
        }

        public string Remove(LapTop lt)
        {
            var clone = _repos.GetAllLapTop(null).FirstOrDefault(x => x.MaLaptop == lt.MaLaptop);
            if (_repos.DeleteLapTop(clone) == true)
            {
                return "Xoa Thanh Cong";
            }
            else
            {
                return "Xoa that bai";
            }
        }

        public string Update(LapTop lt)
        {
            var clone = _repos.GetAllLapTop(null).FirstOrDefault(x => x.MaLaptop == lt.MaLaptop);
            clone.MaLaptop = lt.MaLaptop;
            clone.MaNhanVien = lt.MaNhanVien;
            clone.TenLaptop = lt.TenLaptop;
            clone.CanNang =lt.CanNang;
            clone.MoTa =lt.MoTa;
            clone.TrangThai = lt.TrangThai;

            if (_repos.UpdateLapTop(clone) == true)
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
