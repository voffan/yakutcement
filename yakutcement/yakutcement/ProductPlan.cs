using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace yakutcement
{
    //public enum Progress { start, inwork, done } ?

    public class ProductPlan
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public double Value { get; set; }
        [StringLength(200)]
        public string Progress { get; set; }
        //public Progress Progress { get; set; }
        public int ProductId { get; set; }
        [ForeignKey("ProductId")]
        public virtual Product Product { get; set; }
        [ForeignKey("MasterId")]
        public virtual Person Master { get; set; }
    }
}
