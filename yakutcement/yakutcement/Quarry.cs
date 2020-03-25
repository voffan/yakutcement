using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace yakutcement
{
    public class Quarry
    {
        [Key]
        public int Id { get; set; }
        public int MasterId { get; set; }
        [ForeignKey("MasterId")]
        public virtual Person Master { get; set; }
    }
}
