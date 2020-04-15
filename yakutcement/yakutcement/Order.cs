using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
enum quantity{kg,upakovka,paket}
namespace yakutcement
{
    public enum OrderStatus { Completed, Uncompleted }

    public class Order
    {
        [Key]
        public int OrderId { get; set; }
        public DateTime Date { get; set; }
        public OrderStatus Status { get; set; }
        public int ClientId { get; set; }
        [ForeignKey("ClientId")]
        public int ManagerId { get; set; }
        [ForeignKey("PersonId")]
        public quantity Unit { get; set; }
    }
}