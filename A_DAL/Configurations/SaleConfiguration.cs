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
    public class SaleConfiguration : IEntityTypeConfiguration<Sale>
    {
        public void Configure(EntityTypeBuilder<Sale> builder)
        {
            builder.HasKey(p => new { p.MaSale });// Thiết lập khóa chính


            builder.HasOne(p => p.NhanVien).WithMany(p => p.Sales).HasForeignKey(p => p.MaNhanVien);
        }
    }
}
