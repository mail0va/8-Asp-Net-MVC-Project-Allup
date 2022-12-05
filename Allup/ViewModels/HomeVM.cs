using Allup.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Allup.ViewModels
{
    public class HomeVM
    {
        //public List<Slider> Sliders { get; set; }
        public IEnumerable<Slider> Sliders { get; set; }
        public IEnumerable<Category> Categories { get; set; }
        public IEnumerable<Product> NewArrival { get; set; }
        public IEnumerable<Product> BestSeller { get; set; }
        public IEnumerable<Product> Featured { get; set; }
    }
}
