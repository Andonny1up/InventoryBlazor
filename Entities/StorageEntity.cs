using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class StorageEntity
    {
        [Key]
        [StringLength(50)]
        public string storegeId { get; set; }

        [Required]
        public DateTime lastUpdate { get; set; }

        [Required]
        public int partialQuantity { get; set; }

        //foreikey product
        public string productId { get; set; }
        public ProductEntity product { get; set; }

        //foreikey wherehouse
        public string warehouseId { get; set; }
        public WarehouseEntity warehouse { get; set; }
        //inout
        public ICollection<InOutEntity> inOuts { get; set; }

    }
}
