using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A_DAL.Model
{
    [Table("OCung")]
    public class OCung
    {
        [Key]
        public int MaOCung { get; set; }
        public int DungLuong { get; set; }
        public string Loai { get; set; }
       
        public virtual ICollection<LapTopCT> LapTopCT { get; set; }
    }
}
