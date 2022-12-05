﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Allup.Models
{
    public class Tag:BaseEntity
    {
        [StringLength(500)]
        public string Name { get; set; }
        public IEnumerable<ProductTag> ProductTags { get; set; }

    }
}
