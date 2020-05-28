using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace yakutcement
{
    class IProductionLine
    {
        public static void AddProductionLine(DBContext db, Status status, int factory_id)
        {
            ProductionLine pl = new ProductionLine()
            {
                Status = Status.broken,
                FactoryId = factory_id
            };
        }
    }
}
