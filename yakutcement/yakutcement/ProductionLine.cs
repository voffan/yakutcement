using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace yakutcement
{
	public class ProductionLine
	{
		[Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
		[StringLength(300)]
		public string Status { get; set; }
		public int FactoryId { get; set; }
		[ForeignKey("FactoryId")]
		public virtual Factory Factory { get; set; }
		public virtual ICollection<Product> Products { get; set; }
	}
}