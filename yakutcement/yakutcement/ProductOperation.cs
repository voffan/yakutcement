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
        [ForeignKey("ProductId")]
        public int QuarterMasterId { get; set; }
        [ForeignKey("QuarterMasterId")]
        public virtual Person QuarterMaster { get; set; }
        public int Product { get; set; }
        [ForeignKey("Product")]
        public int Wherehouse { get; set; }
        [ForeignKey("Wherehouse")]
        //public virtual Warehouse Warehouse { get; set; }
    }
}
