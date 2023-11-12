using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A_DAL.Model
{
    [Table("PhanLoai")]
    public class PhanLoai
    {
        [Key]
        public int MaPhanLoai { get; set; }
        public string TenLoai { get; set; }
        public string TrangThai { get; set; }
        
        public virtual ICollection<LapTopCT> LapTopCT { get; set; }
    }
}
