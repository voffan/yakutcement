using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace yakutcement
{
    public enum OrderStatus { Completed, Uncompleted }
    public enum Quantity { kg, upakovka, paket }

    public class Order
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int OrderId { get; set; }
        public DateTime Date { get; set; }
        public OrderStatus Status { get; set; }
        public int ClientId { get; set; }
        [ForeignKey("ClientId")]
        public virtual Client Client { get; set; }
        public int ManagerId { get; set; }
        [ForeignKey("ManagerId")]
        public virtual Person Manager { get; set; }
        public Quantity Unit { get; set; }
    }
}