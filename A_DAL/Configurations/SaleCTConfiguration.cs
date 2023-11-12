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
    public class SaleCTConfiguration : IEntityTypeConfiguration<SaleCT>
    {
        public void Configure(EntityTypeBuilder<SaleCT> builder)
        {
            builder.HasKey(p => new { p.MaSaleChiTiet });// Thiết lập khóa chính

            
            builder.HasOne(p => p.Sale).WithMany(p => p.SaleCT).HasForeignKey(p => p.MaSale);
            builder.HasOne(p => p.LapTopCT).WithMany(p => p.SaleCTs).HasForeignKey(p => p.MaLaptopChiTiet);
           
        }
    }
}
