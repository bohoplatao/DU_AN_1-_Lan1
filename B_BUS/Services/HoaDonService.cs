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
    public class HoaDonService :IHoaDonService
    {
        private HoaDonRepos _repos;
        public HoaDonService()
        {
            _repos = new HoaDonRepos();
        }

        public string Add(HoaDon hd)
        {
            if (_repos.CreateHoaDon(hd) == true)
            {
                return "Them Thanh Cong";
            }
            else
            {
                return "Them that bai";
            }
        }

        public List<HoaDon> GetAll(string search)
        {
            return _repos.GetAllHoaDon().ToList();
        }

        public string Remove(HoaDon hd)
        {
            var clone = _repos.GetAllHoaDon().FirstOrDefault(x => x.MaHoaDon == hd.MaHoaDon);
            if (_repos.DeleteHoaDon(clone) == true)
            {
                return "Xoa Thanh Cong";
            }
            else
            {
                return "Xoa that bai";
            }
        }

        public string Update(HoaDon hd)
        {
            var clone = _repos.GetAllHoaDon().FirstOrDefault(x => x.MaHoaDon == hd.MaHoaDon);
            clone.MaHoaDon = hd.MaHoaDon;

            clone.MaKhachHang = hd.MaKhachHang;
            clone.DiaChi = hd.DiaChi;
            clone.TenNguoiNhan = hd.TenNguoiNhan;
            clone.SoDienThoai = hd.SoDienThoai;
            clone.NgayMua = hd.NgayMua;
            clone.ChuThich = hd.ChuThich;
            
            clone.TongTien = hd.TongTien;

            if (_repos.UpdateHoaDon(clone) == true)
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
