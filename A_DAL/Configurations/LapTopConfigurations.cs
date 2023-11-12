using A_DAL.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A_DAL.Configurations
{
    public class LapTopConfigurations : IEntityTypeConfiguration<LapTop>
    {
        public void Configure(EntityTypeBuilder<LapTop> builder)
        {
         
            builder.HasKey(p => new { p.MaLaptop });// Thiết lập khóa chính

         
            builder.HasOne(p => p.NhanVien).WithMany(p => p.LapTops).HasForeignKey(p => p.MaNhanVien);
          

        }
    }
}
