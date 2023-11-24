using A_DAL.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A_DAL.Configurations
{
    public class SerialConfiguration : IEntityTypeConfiguration<Serial>
    {
        public void Configure(EntityTypeBuilder<Serial> builder)
        {
            builder.HasOne(p => p.LapTopCT).WithMany(p => p.Serials).HasForeignKey(p => p.MaLaptopChiTiet);
           
        }
    }
}
