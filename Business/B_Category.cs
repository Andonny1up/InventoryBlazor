using Entities;
using DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business
{
    public class B_Category
    {
        public static List<CategoryEntity> CategoryList()
        {
            using (var db = new InventaryContext())
            {
                return db.categories.ToList();
            }
        }
        public static CategoryEntity CategoryById(string id)
        {
            using (var db = new InventaryContext())
            {
                return db.categories.ToList().LastOrDefault(c=>c.categoryId==id);
            }
        }
        public static void CreateCategory(CategoryEntity Ocategory)
        {
            using (var db = new InventaryContext())
            {
                db.categories.Add(Ocategory);
                db.SaveChanges();
            }
        }
        public static void UpdateCategory(CategoryEntity Ocategory)
        {
            using (var db = new InventaryContext())
            {
                db.categories.Update(Ocategory);
                db.SaveChanges();
            }
        }

    }
}
