using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class WarehouseEntity
    {
        [Key]
        [StringLength(50)]
        public string warehouseId { get; set; }

        [Required]
        [StringLength(100)]
        public string warehouseName { get; set; }

        [Required]
        [StringLength(100)]
        public string warehouseAddress { get; set; }
        //storage
        public ICollection<StorageEntity> storages { get; set; }
    }
}
