using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace yakutcement
{
    public enum Status { working, broken }

	public class ProductionLine
	{
		[Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
		public Status Status { get; set; }
		public int FactoryId { get; set; }
		[ForeignKey("FactoryId")]
		public virtual Factory Factory { get; set; }
	}
}