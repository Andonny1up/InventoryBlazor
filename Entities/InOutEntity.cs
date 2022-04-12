using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class InOutEntity
    {
        [Key]
        [StringLength(50)]
        public string inOutId { get; set; }

        [Required]
        public DateTime inOutDate { get; set; }

        [Required]
        public int Quantity { get; set; }

        [Required]
        public bool isInput { get; set; }
        //foreikey storage
        public string storageId { get; set; }
        public StorageEntity storage { get; set; }
    }
}
