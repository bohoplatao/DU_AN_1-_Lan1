using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A_DAL.Model
{
    [Table("CardDoHoa")]
    public class CardDoHoa
    {
        [Key]
        public int MaCardDoHoa { get; set; }
        
        public string TenCard { get; set; }
        public int ThongSo { get; set; }
   
        public virtual ICollection<LapTopCT> LapTopCT { get; set; }

    }
}
