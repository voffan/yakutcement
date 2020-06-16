using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace yakutcement
{
    public class IWarehouse
    {
        public static bool AddWarehouse(DBContext DB, double value, int plant_id, int person_id)
        {
            Wherehouse w = new Wherehouse
            {
                Value = value,
                PlantId = plant_id,
                PersonId = person_id
            };
            DB.Warehouses.Add(w);
            DB.SaveChanges();
            return true;
        }

        public static bool DeleteWarehouse(DBContext db, int id)
        {
            var w = (from warehouse in db.Warehouses where warehouse.Id == id select warehouse).FirstOrDefault<Wherehouse>();
            db.Warehouses.Remove(w);
            db.SaveChanges();
            return true;
        }
    }
}
