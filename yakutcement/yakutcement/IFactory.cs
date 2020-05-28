using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace yakutcement
{
    class IFactory
    {
        public static bool factoryexist(DBContext db)
        {
            if (db.Factories.Count()>0) return true;
            else return false;
        }

        public static void AddFactory()
        {

        }
    }
}
