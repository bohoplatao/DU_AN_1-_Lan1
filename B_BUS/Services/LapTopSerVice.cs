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
        
       
        public LapTopSerVice()
        {
            _repos = new LapTopRepos();
            
            
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
            int searhInt;

            if (string.IsNullOrEmpty(search))
            {
                return _repos.GetAllLapTop().ToList();
            }
            else if (int.TryParse(search, out searhInt))
            {
                return _repos.GetLTByGia(searhInt).ToList();
            }
            else
            {
                return _repos.GetPhanLoaiLapTop(search).ToList();
            }
            
        }

        public string Remove(LapTop lt)
        {
            var clone = _repos.GetAllLapTop().FirstOrDefault(x => x.MaLaptop == lt.MaLaptop);
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
            var clone = _repos.GetAllLapTop().FirstOrDefault(x => x.MaLaptop == lt.MaLaptop);
            clone.MaLaptop = lt.MaLaptop;
            
            clone.TenLaptop = lt.TenLaptop;
            clone.CanNang =lt.CanNang;
            clone.MoTa =lt.MoTa;
            clone.TrangThai = lt.TrangThai;
            clone.HinhAnh = lt.HinhAnh;
            clone.Soluong = lt.Soluong;

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
