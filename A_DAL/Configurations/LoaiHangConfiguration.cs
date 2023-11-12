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
    public class LoaiHangConfiguration : IEntityTypeConfiguration<LoaiHang>
    {
        public void Configure(EntityTypeBuilder<LoaiHang> builder)
        {
            builder.HasKey(p => new { p.MaLoaiHang });// Thiết lập khóa chính


            builder.HasOne(p => p.NhaCungCap).WithMany(p => p.LoaiHang).HasForeignKey(p => p.MaNhaCungCap);
        }
    }
}
