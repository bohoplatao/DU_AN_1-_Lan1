using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A_DAL.Model
{
    [Table("ManHinh")]
    public class ManHinh
    {
        [Key]
        public int MaManHinh { get; set; }
        public string TenManHinh { get; set; }
        public string LoaiManHinh { get; set; }
        public int TanSo { get; set; }
       
        public virtual ICollection<LapTopCT> LapTopCT { get; set; }
    }
}
