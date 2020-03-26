using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace yakutcement
{
  
    // Физ лицо или юр лицо
    //public enum ClientType { Individual, Entity }

    public class Client
    {
        [Key]
        public int PersonId { get; set; }
        [ForeignKey("PersonId")]
        public virtual Person Client { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string Telephone { get; set; }
        public string Email { get; set; }
        public string Inn { get; set; }
        //public ClientType Type { get; set; }
    }

    /* Если же мы все таки добавим компании - клиенты:

    public int CompanyId { get; set; }
    [ForeignKey("CompanyId")]
    public virtual Сompany Client { get; set; }
    
     */
}
