using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace yakutcement
{
    public class SupplyRemain
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public int SupplyId { get; set; }
        [ForeignKey("SupplyId")]
        public virtual Supply Supply { get; set; }
        public double Value { get; set; }
    }
}
