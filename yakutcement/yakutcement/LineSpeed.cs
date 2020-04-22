using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace yakutcement
{
	public class LineSpeed
	{
		[Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
		public int Id { get; set; }
        public int ProductionLineId { get; set; }
        [ForeignKey("ProductionLineId")]
        public ProductionLine ProductionLine { get; set; }
        public int ProductId { get; set; }
        [ForeignKey("ProductId")]
        public Product Product { get; set; }
		public double Speed { get; set; }

	}
}