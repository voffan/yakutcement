using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace yakutcement
{
    public class Supply
    {
		
        [Key]
        public int Id { get; set; }
		public double Value { get; set; }
		[ForeignKey("PlantId")]
		public virtual Plant Plant { get; set; }
		
    }
}
