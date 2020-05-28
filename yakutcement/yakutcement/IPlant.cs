using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace yakutcement
{
    class IPlant
    {
        public static bool plantexist(DBContext db)
        {
            if (db.Plants.Count()>0) return true;
            else return false;
        }
        public static void AddPlant(DBContext db, string p_name, string p_address, string p_telephone, int p_inn, int p_kpp)
        {
            Plant p = new Plant()
            {
                name = p_name,
                addres = p_address,
                telephone = p_telephone,
                inn = p_inn,
                kpp = p_kpp
            };
            db.Plants.Add(p);
            db.SaveChanges();
        }
        public static Plant AddDefaultPlant(DBContext db)
        {
            Plant p = new Plant()
            {
                name = "Контора математиков",
                addres = "Каландарашвили",
                telephone = "8-800-7553535",
                inn = 231488122,
                kpp = 133231313
            };
            db.Plants.Add(p);
            db.SaveChanges();
            return p;
        }
    }
}
