using Allup.Models;
using Allup.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Allup.ComponentViewModels
{
    public class HeaderVM
    {
        public Dictionary<string, string> Settings { get; set; }

        public IEnumerable<Category> Categories { get; set; }

        public IEnumerable<BasketVM> BasketVMs { get; set; }
    }
}
