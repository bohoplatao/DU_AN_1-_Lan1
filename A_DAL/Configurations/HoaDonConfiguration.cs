using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using A_DAL.Model;

namespace A_DAL.Configurations
{
    public class HoaDonConfiguration : IEntityTypeConfiguration<HoaDon>
    {
        public void Configure(EntityTypeBuilder<HoaDon> builder)
        {
            
            builder.HasKey(p => new { p.MaHoaDon });// Thiết lập khóa chính

            builder.HasOne(p => p.KhachHang).WithMany(p => p.HoaDon).HasForeignKey(p => p.MaKhachHang);
            builder.HasOne(p => p.NhanVien).WithMany(p => p.HoaDons).HasForeignKey(p => p.MaNhanVien);
            

        }
    }
}
