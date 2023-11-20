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
    public class KhachHangService : IServiceKH
    {
        private KhachHangRepos _repos;
        public KhachHangService()
        {
            _repos = new KhachHangRepos();
        }

        public string Add(KhachHang kh)
        {
            if (_repos.CreateKH(kh) == true)
            {
                return "Them Thanh Cong";
            }
            else
            {
                return "Them that bai";
            }
        }

        public List<KhachHang> GetAll(string search)
        {
            if (search == null)
            {
                return _repos.GetAllKH(null).ToList();
            }
            else
            {
                return _repos.GetAllKH(null).Where(x => x.TenKhachHang.Contains(search)).ToList();
            };
        }

        public string Remove(KhachHang kh)
        {
            var clone = _repos.GetAllKH(null).FirstOrDefault(x => x.MaKhachHang == kh.MaKhachHang);
            if (_repos.DeleteKH(clone) == true)
            {
                return "Xoa Thanh Cong";
            }
            else
            {
                return "Xoa that bai";
            }
        }

        public string Update(KhachHang kh)
        {
            var clone = _repos.GetAllKH(null).FirstOrDefault(x => x.MaKhachHang == kh.MaKhachHang);
            clone.MaKhachHang = kh.MaKhachHang;
            clone.TenKhachHang = kh.TenKhachHang;
            clone.DiaChi = kh.DiaChi;
            clone.HinhAnh = kh.HinhAnh;
            clone.SoDienThoai = kh.SoDienThoai;
            clone.NgaySinh = kh.NgaySinh;
            if (_repos.UpdateKH(clone) == true)
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
