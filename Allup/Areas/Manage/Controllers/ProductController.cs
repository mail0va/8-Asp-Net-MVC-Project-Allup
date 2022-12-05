using Allup.DAL;
using Allup.Models;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Allup.Areas.Manage.Controllers
{
    [Area("manage")]
    public class ProductController : Controller
    {
        private readonly AppDbContext _context;
        private readonly IWebHostEnvironment _env;

        public ProductController(AppDbContext context, IWebHostEnvironment env)
        {
            _context = context;
            _env = env;
        }

        public async Task<IActionResult> Index()
        {
            IEnumerable<Product> products = await _context.Products
               .Include(t => t.Brand)
               .Include(t => t.Category)
               .Include(t => t.ProductTags).ThenInclude(pt => pt.Tag)
               .Where(p=>p.IsDeleted==false)
               .ToListAsync();

            return View(products);
        }
    }
}
