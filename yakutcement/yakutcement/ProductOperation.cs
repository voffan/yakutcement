using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace yakutcement
{
    public class ProductOperation
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public double Value { get; set; }
        public string OperationType { get; set; }
        public int ProductId { get; set; }
        public int QuarterMasterId { get; set; }
        public int WherehouseId {get;set;}
        [ForeignKey("QuarterMasterId")]
        public virtual Person QuarterMaster { get; set; }
        [ForeignKey("ProductId")]
        public int Product { get; set; }
        [ForeignKey("WhereHouseId")]
        public virtual Wherehouse Wherehouse { get; set; }
    }
}
