using DataAccess;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Business
{
    public class B_Storage
    {
        public static List<StorageEntity> StorageList()
        {
            using (var db = new InventaryContext())
            {
                return db.storages.ToList();
            }
        }
        public static void CreateStorage(StorageEntity OstorageEntity)
        {
            using (var db = new InventaryContext())
            {
                db.storages.Add(OstorageEntity);
                db.SaveChanges();
            }
        }
        public static bool IfProductInWarehouse(string idStorage)
        {
            using (var db = new InventaryContext())
            {
                var product = db.storages.ToList().Where(s => s.storegeId == idStorage);
                return product.Any();
            }
        }
        public static List<StorageEntity> StorageProductByWarehouse(string idWarehouse)
        {
            using (var db = new InventaryContext())
            {
                return db.storages
                    .Include(s => s.product)
                    .Include(s => s.warehouse)
                    .Where(s => s.warehouseId == idWarehouse)
                    .ToList();
            }
        }
        public static void UpdateStorage(StorageEntity OstorageEntity)
        {
            using (var db = new InventaryContext())
            {
                db.storages.Update(OstorageEntity);
                db.SaveChanges();
            }
        }
    }
}
