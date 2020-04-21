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
	public virtual DbSet<Plant> Plant { get; set; }
	public virtual DbSet<ProductPlan> ProductPlan { get; set; }
	public virtual DbSet<SupplyPlan> SupplyPlan{ get; set; }
<<<<<<< HEAD
    public virtual DbSet<ProductOperation> ProductOperation { get; set; }
=======
	public virtual DbSet<ProductPlan> Order { get; set; }
>>>>>>> 6c2e8a59e901f7aad4ed21cf010e791ab4699b5e


    }
}
