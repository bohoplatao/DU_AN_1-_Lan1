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
    public class LapTopCTConfiguration : IEntityTypeConfiguration<LapTopCT>
    {
        public void Configure(EntityTypeBuilder<LapTopCT> builder)
        {
            builder.HasKey(p => new { p.MaLaptopChiTiet });// Thiết lập khóa chính

            builder.HasOne(p => p.LoaiHang).WithMany(p =>p.LapTopCTs).HasForeignKey(p => p.MaLoaiHang);
            builder.HasOne(p => p.Pin).WithMany(p => p.LapTopCT).HasForeignKey(p => p.MaPin);
            builder.HasOne(p => p.PhanLoai).WithMany(p => p.LapTopCT).HasForeignKey(p => p.MaPhanLoai);
            builder.HasOne(p => p.Chip).WithMany(p => p.LapTopCT).HasForeignKey(p => p.MaChip);
            builder.HasOne(p => p.Ram).WithMany(p => p.LapTopCT).HasForeignKey(p => p.MaRAM);
            builder.HasOne(p => p.CardDoHoa).WithMany(p => p.LapTopCT).HasForeignKey(p => p.MaCardDoHoa);
            builder.HasOne(p => p.LapTop).WithMany(p => p.LapTopCT).HasForeignKey(p => p.MaLaptop);
            builder.HasOne(p => p.ManHinh).WithMany(p => p.LapTopCT).HasForeignKey(p => p.MaManHinh);
            builder.HasOne(p => p.Ocung).WithMany(p => p.LapTopCT).HasForeignKey(p => p.MaOCung);
           


        }
    }
}
