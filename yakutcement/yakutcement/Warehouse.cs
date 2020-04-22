using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace yakutcement
{
    public class Wherehouse
    {
		
        [Key]
    	[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
	    public double Value { get; set; }
        public int PlantId { get; set; }
	    [ForeignKey("PlantId")]
	    public virtual Plant Plant { get; set; }
        public int PersonId { get; set; }
	    [ForeignKey("PersonId")]
	    public virtual Person HouseKeeper { get; set; }	
    }
}
