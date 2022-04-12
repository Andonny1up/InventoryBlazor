using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class ProductEntity
    {
        [Key]
        [StringLength(10)]
        public string productId { get; set; }

        [Required]
        [StringLength(100)]
        public string productName { get; set; }

        [StringLength(600)]
        public string productDescription { get; set; }

        public int totalQuantity { get; set; }
        //foreikeyCategory
        public string categoryId { get; set; }
        public CategoryEntity category { get; set; }
        //storage
        public ICollection<StorageEntity> storages { get; set; }

    }
}
