using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace yakutcement
{
    public class Factory
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public int MasterId { get; set; }
        [ForeignKey("MasterId")]
        public virtual Person Master { get; set; }
        public int PlantId { get; set; }
        [ForeignKey("PlantId")]
        public virtual Plant Plant { get; set; }
        public virtual ICollection<ProductionLine> ProductionLines { get; set; }
    }
}
