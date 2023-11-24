using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A_DAL.Model
{
    [Table("Serial")]
    public class Serial
    {
        [Key]
        public int MaSerial { get; set; }
        public int MaLaptopChiTiet { get; set; }
        public virtual LapTopCT LapTopCT { get; set; }
        public virtual HoaDonCT HoaDonCT { get; set; }

        public bool TrangThai { get; set; }


    }
}
