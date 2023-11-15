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
    public class PhanLoaiService : IPhanLoaiService
    {
        private TheLoaiRepos _repos;
        public PhanLoaiService()
        {
            _repos = new TheLoaiRepos();
        }
        public string Add(PhanLoai pl)
        {
            if (_repos.CreatePhanLoai(pl) == true)
            {
                return "Them Thanh Cong";
            }
            else
            {
                return "Them that bai";
            }
        }

        public List<PhanLoai> GetAll(string search)
        {
            if (search == null)
            {
                return _repos.GetAllPhanLoai(null).ToList();
            }
            else
            {
                return _repos.GetAllPhanLoai(null).Where(x => x.TenLoai.Contains(search)).ToList();
            }
        }

        public string Remove(PhanLoai pl)
        {
            var clone = _repos.GetAllPhanLoai(null).FirstOrDefault(x => x.MaPhanLoai == pl.MaPhanLoai);
            if (_repos.DeletePhanLoai(clone) == true)
            {
                return "Xoa Thanh Cong";
            }
            else
            {
                return "Xoa that bai";
            }
        }

        public string Update(PhanLoai pl)
        {
            var clone = _repos.GetAllPhanLoai(null).FirstOrDefault(x => x.MaPhanLoai == pl.MaPhanLoai);
            clone.MaPhanLoai = pl.MaPhanLoai;
            clone.TenLoai = pl.TenLoai;
            clone.TrangThai = pl.TrangThai;

            if (_repos.UpdatePhanLoai(clone) == true)
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
