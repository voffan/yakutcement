using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace yakutcement
{
	public enum Progress { inplan, inwork, done }
	public class SupplyPlan
	{
		[Key]
        	[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
		public int Id { get; set; }
		public DateTime Date { get; set; }
		public double Value { get; set; }
		public Progress Progress { get; set; }
		public int SupplyId { get; set; }
		[ForeignKey("SupplyId")]
		public virtual Supply Supply { get; set; }
		public int MasterId{ get; set; }
		[ForeignKey("MasterId")]
		public virtual Person Master { get; set; }
	}
}
