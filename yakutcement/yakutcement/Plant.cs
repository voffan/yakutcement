using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace yakutcement
{
    public class Plant
    {
        [Key]
        public int Id { get; set; }
        // some other fields

        public virtual ICollection<Quarry> Quarries { get; set; }
    }
}
