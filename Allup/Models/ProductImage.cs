using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Allup.Models
{
    public class ProductImage:BaseEntity
    {
        [StringLength(1000)]
        public string Name { get; set; }
        public int ProductId { get; set; }
        public Product Product { get; set; }
    }
}
