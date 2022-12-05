using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Allup.Models
{
    public class Setting
    {
        public int Id { get; set; }
        [StringLength(500)]
        public string Key { get; set; }
        [StringLength(1000)]
        public string Value { get; set; }
    }
}
