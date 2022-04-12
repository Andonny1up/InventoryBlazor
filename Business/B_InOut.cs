using DataAccess;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business
{
    public class B_InOut
    {
        public List<InOutEntity> InOutList()
        {
            using (var db = new InventaryContext())
            {
                return db.inOuts.ToList();
            }
        }
        public void CreateInOut(InOutEntity OinOutEntity)
        {
            using (var db = new InventaryContext())
            {
                db.inOuts.Add(OinOutEntity);
                db.SaveChanges();
            }
        }
        public void UpdateInOut(InOutEntity OinOutEntity)
        {
            using (var db = new InventaryContext())
            {
                db.inOuts.Update(OinOutEntity);
                db.SaveChanges();
            }
        }
    }
}
