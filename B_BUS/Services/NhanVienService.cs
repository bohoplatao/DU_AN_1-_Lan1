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
    public class NhanVienService : INhanVienService
    {
        private NhanVienRepos _repos;
        public NhanVienService()
        {
            _repos = new NhanVienRepos();
        }
        public string Add(NhanVien nv)
        {
            if (_repos.CreateNhanVien(nv) == true)
            {
                return "Them Thanh Cong";
            }
            else
            {
                return "Them that bai";
            }
        }

        public List<NhanVien> GetAll(string search)
        {
            if (search == null)
            {
                return _repos.GetAllNhanVien(null).ToList();
            }
            else
            {
                return _repos.GetAllNhanVien(null).Where(x => x.TenNhanVien.Contains(search)).ToList();
            }
        }

        public string Remove(NhanVien nv)
        {
            var clone = _repos.GetAllNhanVien(null).FirstOrDefault(x => x.MaNhanVien == nv.MaNhanVien);
            if (_repos.DeleteNhanVien(clone) == true)
            {
                return "Xoa Thanh Cong";
            }
            else
            {
                return "Xoa that bai";
            }
        }

        public string Update(NhanVien nv)
        {
            var clone = _repos.GetAllNhanVien(null).FirstOrDefault(x => x.MaNhanVien == nv.MaNhanVien);
            clone.MaNhanVien = nv.MaNhanVien;

            clone.TenNhanVien = nv.TenNhanVien;
            clone.DiaChi = nv.DiaChi;
            clone.HinhAnh = nv.HinhAnh;
            clone.SoDienThoai = nv.SoDienThoai;
            clone.MatKhau = nv.MatKhau;
            clone.QRCode = nv.QRCode;

            if (_repos.UpdateNhanVien(clone) == true)
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
