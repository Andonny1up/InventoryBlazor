using DataAccess;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business
{
    public class B_Product
    {
        public static List<ProductEntity> ProductList()
        {
            using (var db = new InventaryContext())
            {
                return db.products.ToList();
            }
        }
        public static ProductEntity ProductById(string id)
        {
            using (var db = new InventaryContext())
            {
                return db.products.ToList().LastOrDefault(p=>p.productId==id);
            }
        }
        public static void CreateProduct(ProductEntity Oproduct)
        {
            using (var db = new InventaryContext())
            {
                db.products.Add(Oproduct);
                db.SaveChanges();
            }
        }
        public static void UpdateProduct(ProductEntity Oproduct)
        {
            using (var db = new InventaryContext())
            {
                db.products.Update(Oproduct);
                db.SaveChanges();
            }
        }
    }
}
