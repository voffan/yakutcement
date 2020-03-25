using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace yakutcement
{
  
    //Физ лицо или юр лицо
    public enum ClientType { Individual, Entity }

    public class Client
    {
        [Key]
        public int PersonId { get; set; }
        [ForeignKey("PersonId")]
        public virtual Person Master { get; set; }
        public ClientType Type { get; set; }
    }
    /* Если же м все таки добавим компании - клиенты:
     * 
     * public int CompanyId { get; set; }
        [ForeignKey("CompanyId")]
     */
}
