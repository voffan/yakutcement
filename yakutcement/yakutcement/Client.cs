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
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [StringLength(300)]
        public string Name { get; set; }
        public string Address { get; set; }
        [StringLength(12)]
        public string Telephone { get; set; }
        [StringLength(255)]
        public string Email { get; set; }
        [StringLength(20)]
        public string Inn { get; set; }

        public string Login { get; set; }
        public string Password { get; set; }
        //public ClientType Type { get; set; }
    }

    /* Если же мы все таки добавим компании - клиенты:

    public int CompanyId { get; set; }
    [ForeignKey("CompanyId")]
    public virtual Сompany Client { get; set; }
    
     */
}
