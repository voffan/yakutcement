using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace yakutcement
{
	public enum SupplyType { Raw, Processed }
	
    public class Supply
    {
		
        [Key]
		[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int SuppId { get; set; }
        public string Name { get; set; }
		public string Info { get; set; }
		public double Price { get; set; }
		public virtual SupplyType SupplyType { get; set; }
		public virtual Quarry Quarry { get; set; }
		
    }
}
