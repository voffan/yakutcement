using System;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;

namespace yakutcement
{
    public partial class DBContext : DbContext
    {
        public DBContext()
            : base("")
        {
        }

        public virtual DbSet<Client> Clients { get; set; }
	public virtual DbSet<ProductPlan> ProductPlan { get; set; }
	public virtual DbSet<SupplyPlan> SupplyPlan{ get; set; }


    }
}
