using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A_DAL.Model
{
    [Table("LapTop")]
    public class LapTop
    {
        
        public int MaLaptop { get; set; }
        
        public string TenLaptop { get; set; }
        public float CanNang { get; set; }
        public string MoTa { get; set; }
        public bool TrangThai { get; set; }

        public string HinhAnh { get; set; }
        public int Soluong { get; set; }


        public virtual ICollection<LapTopCT> LapTopCT { get; set; }
    }
}
