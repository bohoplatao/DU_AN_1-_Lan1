using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A_DAL.Model
{
    [Table("Ram")]
    public class Ram
    {
        [Key]
        public int MaRam { get; set; }
        public string TenRam { get; set; }
        public int Bus { get; set; }
        public int DungLuongRam { get; set; }
       
        public virtual ICollection<LapTopCT> LapTopCT { get; set; }
    }
}
