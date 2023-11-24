using A_DAL.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A_DAL.Configurations
{
    public class HoaDonCTConfiguration : IEntityTypeConfiguration<HoaDonCT>
    {
        public void Configure(EntityTypeBuilder<HoaDonCT> builder)
        {
            builder.HasKey(p => new { p.MaHoaDonChiTiet });// Thiết lập khóa chính



            builder.HasOne(p => p.HoaDon).WithMany(p => p.HoaDonCTs).HasForeignKey(p => p.MaHoaDon);
            builder.HasOne(p => p.DanhGia).WithMany(p => p.HoaDonCTs).HasForeignKey(p => p.MaDanhGia);
            

        }
    }
}
