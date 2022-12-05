using Allup.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Allup.ComponentViewModels
{
    public class ProductVM
    {
        public IEnumerable<Product> NewArrival { get; set; }
        public IEnumerable<Product> BestSeller { get; set; }
        public IEnumerable<Product> Featured { get; set; }
    }
}
