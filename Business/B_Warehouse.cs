using DataAccess;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business
{
    public class B_Warehouse
    {
        public static List<WarehouseEntity> WarehousesList()
        {
            using (var db = new InventaryContext())
            {
                return db.warehouses.ToList();
            }
        }
        public void CreateWareHouse(WarehouseEntity Owarehouse)
        {
            using (var db = new InventaryContext())
            {
                db.warehouses.Add(Owarehouse);
                db.SaveChanges();
            }
        }
        public void UpdateWareHouse(WarehouseEntity Owarehouse)
        {
            using (var db = new InventaryContext())
            {
                db.warehouses.Update(Owarehouse);
                db.SaveChanges();
            }
        }
    }
}
