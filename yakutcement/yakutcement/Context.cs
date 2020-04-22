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
	    public virtual DbSet<Plant> Plants { get; set; }
	    public virtual DbSet<ProductPlan> ProductPlans { get; set; }
	    public virtual DbSet<ProductionLine> ProductionLines { get; set; }
	    public virtual DbSet<SupplyPlan> SupplyPlans { get; set; }
	    public virtual DbSet<Wherehouse> Warehouses { get; set; }
        public virtual DbSet<ProductOperation> ProductOperations { get; set; }
	    public virtual DbSet<Order> Orders { get; set; }
        public virtual DbSet<Product> Products { get; set; }


    }
}
