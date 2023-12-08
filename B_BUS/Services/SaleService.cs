using A_DAL.Model;
using A_DAL.Repositories;
using A_DAL.ViewModels;
using B_BUS.IServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B_BUS.Services
{
    public class SaleService : ISaleService
    {
        private SaleRepos _repos;
        private NhanVienRepos _nhanVienRepos;
        public SaleService()
        {
            _repos = new SaleRepos();
            _nhanVienRepos = new NhanVienRepos();   
        }

        public string Add(Sale s)
        {
            if (_repos.CreateSALE(s) == true)
            {
                return "Them Thanh Cong";
            }
            else
            {
                return "Them that bai";
            }
        }

        public List<Sale> GetAll(string search)
        {
            if (search == null)
            {
                return _repos.GetAllSALE().ToList();
            }
            else
            {
                return _repos.GetAllSALE().Where(x => x.TenDotSale.Contains(search)).ToList();
            }
        }

        public List<Sale> GetAllSALE()
        {
            return _repos.GetSALE();
        }

        public string Remove(Sale s)
        {
            var clone = _repos.GetAllSALE().FirstOrDefault(x => x.MaSale == s.MaSale);
            if (_repos.DeleteSALE(clone) == true)
            {
                return "Xoa Thanh Cong";
            }
            else
            {
                return "Xoa that bai";
            }
        }

        public string Update(Sale s)
        {
            var clone = _repos.GetAllSALE().FirstOrDefault(x => x.MaSale == s.MaSale);
            clone.MaNhanVien = s.MaNhanVien;
            clone.TenDotSale = s.TenDotSale;
            clone.ThoiGianBD = s.ThoiGianBD;
            clone.ThoiGianKT = s.ThoiGianKT;
            
            if (_repos.UpdateSALE(clone) == true)
            {
                return "Sua Thanh Cong";
            }
            else
            {
                return "Sua that bai";
            }
        }


        public List<NhanVienWithSale> GetNhanVienWithSales()
        {
            var data = (from sale in _repos.GetAllSALE()
                        join nv in _nhanVienRepos.GetAllNhanVien()
                        on sale.MaNhanVien equals nv.MaNhanVien
                        select new NhanVienWithSale
                        {
                            MaSale = sale.MaSale,
                            MaNhanVien = nv.MaNhanVien,
                            TenDotSale = sale.TenDotSale,
                            ThoiGianBD = sale.ThoiGianBD,
                            ThoiGianKT = sale.ThoiGianKT,
                            TenNhanVien = nv.TenNhanVien,
                            SoDienThoai = nv.SoDienThoai
                        }
                        ).ToList();
            return data;
        }
    }
}
