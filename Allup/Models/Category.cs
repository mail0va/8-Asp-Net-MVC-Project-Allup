﻿using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Allup.Models
{
    public class Category : BaseEntity
    {
        [Required]
        [StringLength(500)]
        public string Name { get; set; }
        [StringLength(2000)]
        public string Image { get; set; }
        public bool IsMain { get; set; }
        public Nullable<int> ParentId { get; set; }
        public Category Parent { get; set; }
        public IEnumerable<Category> Children { get; set; }
        public IEnumerable<Product> Products { get; set; }

        [NotMapped]
        public IFormFile File { get; set; }
    }
}
