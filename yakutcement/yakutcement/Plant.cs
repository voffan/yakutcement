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
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string name {  get; set; }
        public string addres { get; set; }
        public string telephone { get; set; }
        public int inn { get; set; }
        public int kpp { get; set; }
        // some other fields

        public virtual ICollection<Quarry> Quarries { get; set; }
    }
}
