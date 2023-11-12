using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A_DAL.Model
{
    [Table("Pin")]
    public class Pin
    {
        [Key]
        public int MaPin { get; set; }
        public string TenPin { get; set; }
        public string DungLuong { get; set; }
        
        public virtual ICollection<LapTopCT> LapTopCT { get; set; }
    }
}
