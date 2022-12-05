using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Allup.Models
{
    public class Slider : BaseEntity
    {
        [StringLength(1000)]
        public string MainTitle { get; set; }
        [StringLength(2000)]
        public string SubTitle { get; set; }
        [StringLength(2500)]
        public string Desc { get; set; }
        [StringLength(3000)]
        public string Image { get; set; }
        [StringLength(1000)]
        public string PageLink { get; set; }
    }
}
