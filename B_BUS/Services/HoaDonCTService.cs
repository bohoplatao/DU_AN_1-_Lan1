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
    public class HoaDonCTService:IHoaDonCTService
    {
        private HoaDonCTRepos _repos;
        public HoaDonCTService()
        {
            _repos = new HoaDonCTRepos();
        }

        public string Add(HoaDonCT hd)
        {
            if (_repos.CreateHoaDonCT(hd) == true)
            {
                return "Them Thanh Cong";
            }
            else
            {
                return "Them that bai";
            }
        }

        public List<HoaDonCT> GetAllHDCT()
        {
            return _repos.GetHoaDonCTs();
        }

        public List<HoaDonCT> GetAll(string search)
        {
            var x = _repos.GetHoaDonCTs().ToList();
            return x;
        }

        public string Remove(HoaDonCT hd)
        {
            var clone = _repos.GetHoaDonCTs().FirstOrDefault(x => x.MaHoaDonChiTiet == hd.MaHoaDonChiTiet);
            if (_repos.DeleteHoaDonCT(clone) == true)
            {
                return "Xoa Thanh Cong";
            }
            else
            {
                return "Xoa that bai";
            }
        }

        public string Update(HoaDonCT hd)
        {
            var clone = _repos.GetHoaDonCTs().FirstOrDefault(x => x.MaHoaDonChiTiet == hd.MaHoaDonChiTiet);
            clone.MaHoaDon = hd.MaHoaDon;

            //clone.MaKhachHang = hd.MaKhachHang;
            //clone.DiaChi = hd.DiaChi;
            //clone.TenNguoiNhan = hd.TenNguoiNhan;
            //clone.SoDienThoai = hd.SoDienThoai;
            //clone.NgayMua = hd.NgayMua;
            //clone.ChuThich = hd.ChuThich;

            //clone.TongTien = hd.TongTien;
            clone.MaHoaDonChiTiet = hd.MaHoaDonChiTiet;
            clone.MaHoaDon = hd.MaHoaDon;
            clone.MaSerial = hd.MaSerial;
            clone.Gia =hd.Gia;

            if (_repos.UpdateHoaDonCT(clone) == true)
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
