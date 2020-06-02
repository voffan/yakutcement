using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace yakutcement
{
    public class IProduct
    {
        public static bool AddProduct(DBContext db, string name, string description, double price)
        {
            Product product = new Product
            {
                Name = name,
                Description = description,
                Price = price
            };
            db.Products.Add(product);
            db.SaveChanges();
            return true;
        }
        public static bool EditProduct(DBContext db, int id, string name, string description, double price)
        {
            Product p = (from product in db.Products where product.Id == id select product).FirstOrDefault<Product>();
            p.Name = name;
            p.Description = description;
            p.Price = price;
            db.SaveChanges();
            return false;
        }
        public static bool DeleteProduct(DBContext db, int id)
        {
            var p = (from product in db.Products where product.Id == id select product).FirstOrDefault<Product>();
            db.Products.Remove(p);
            db.SaveChanges();
            return true;
        }
    }
}
