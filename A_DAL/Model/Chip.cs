using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A_DAL.Model
{
    [Table("Chip")]
    public class Chip
    {
        [Key]
        public int MaChip { get; set; }
        public string TenChip { get; set; }
        public int ThongSo { get; set; }
        
        public virtual ICollection<LapTopCT> LapTopCT { get; set; }
    }
}
