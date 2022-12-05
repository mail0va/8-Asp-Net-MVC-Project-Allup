using Allup.DAL;
using Allup.Models;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace Allup.Areas.Manage.Controllers
{
    [Area("manage")]
    public class CategoryController : Controller
    {
        private readonly AppDbContext _context;
        private readonly IWebHostEnvironment _env;

        public CategoryController(AppDbContext context, IWebHostEnvironment env)
        {
            _context = context;
            _env = env;
        }

        public async Task<IActionResult> Index()
        {
            IEnumerable<Category> categories = await _context.Categories.Include(c => c.Products)
            .Where(c => c.IsDeleted == false && c.IsMain == true).ToListAsync();
            return View(categories);
        }
        [HttpGet]
        public async Task<IActionResult> Create()
        {
            ViewBag.Categories = await _context.Categories
            .Where(c => c.IsDeleted == false && c.IsMain == true).ToListAsync();
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Category category)
        {
            ViewBag.Categories = await _context.Categories
            .Where(c => c.IsDeleted == false && c.IsMain == true).ToListAsync();

            if (!ModelState.IsValid) return View();

            if (await _context.Categories.AnyAsync(c => c.IsDeleted == false && c.Name.ToLower() == category.Name.ToLower().Trim()))
            {
                ModelState.AddModelError("Name", $"This name - {category.Name} - already exists");
                return View(category);
            }

            if (category.IsMain)
            {
                if (category.File == null)
                {
                    ModelState.AddModelError("File", "File mecburdur !");
                    return View(category);
                }
                if (category.File.ContentType != "image/jpg")
                {
                    ModelState.AddModelError("File", "File type jpg ve ya jpeg olmalidi !");
                    return View(category);
                }

                if ((category.File.Length / 1024) > 20)
                {
                    ModelState.AddModelError("File", "File olcusu maksimum 20 kb olmalidir !");
                    return View(category);
                }

                string fileName = Guid.NewGuid().ToString() + "-" + DateTime.UtcNow.AddHours(4)
                .ToString("yyyyMMddHHmmss") + "-" + category.File.FileName;

                string path = @"C:\Users\Lenovo\source\repos\Allup\Allup\wwwroot\assets\images" + category.File.FileName;

                using (FileStream fileStream = new FileStream(path, FileMode.Create))
                {
                    await category.File.CopyToAsync(fileStream);
                }

                category.ParentId = null;
                category.Image = fileName;
            }
            else
            {
                if (category.ParentId == null)
                {
                    ModelState.AddModelError("ParentId", "Ust category mutleq secilmelidir !");
                    return View(category);
                }

                if (await _context.Categories.AnyAsync(c => c.IsDeleted == false && c.IsMain && c.Id == category.ParentId))
                {
                    ModelState.AddModelError("ParentId", "Duzgun ust category sec !");
                    return View(category);
                }

                category.Image = null;
            }

            category.Name = category.Name.Trim();
            category.IsDeleted = false;
            category.CreatedAt = DateTime.UtcNow.AddHours(4);
            category.CreatedBy = "System";

            await _context.Categories.AddAsync(category);
            await _context.SaveChangesAsync();
            return RedirectToAction("Index");
        }

        [HttpGet]
        public async Task<IActionResult> Update(int? id)
        {
            if (id == null) return BadRequest("Id bos ola bilmez !");

            Category category = await _context.Categories.FirstOrDefaultAsync(c => c.IsDeleted == false && c.Id == id);

            if (category == null) return NotFound("Daxil edilen Id yanlisdir");

            ViewBag.Categories = await _context.Categories
            .Where(c => c.IsDeleted == false && c.IsMain == true).ToListAsync();
            return View(category);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Update(int? id, Category category)
        {

            ViewBag.Categories = await _context.Categories
            .Where(c => c.IsDeleted == false && c.IsMain == true).ToListAsync();

            if (!ModelState.IsValid) return View();

            if (id == null) return BadRequest("Id bos ola bilmez !");

            Category existedCategory = await _context.Categories.FirstOrDefaultAsync(c => c.IsDeleted == false && c.Id == id);

            if (existedCategory == null) return NotFound("Daxil edilen Id yanlisdir");

            if (category.Id != id) return BadRequest("Id ferqli ola bilmez !");

            if (category.IsMain)
            {
                if (existedCategory.Image == null && category.File == null)
                {
                    ModelState.AddModelError("File", "File mecburdur !");
                    return View(category);
                }
                if (category.File != null)
                {
                    if (category.File.ContentType != "image/jpg")
                    {
                        ModelState.AddModelError("File", "File type jpg ve ya jpeg olmalidi !");
                        return View(category);
                    }

                    if ((category.File.Length / 1024) > 20)
                    {
                        ModelState.AddModelError("File", "File olcusu maksimum 20 kb olmalidir !");
                        return View(category);
                    }

                    //string path = @"C:\Users\Lenovo\source\repos\Allup\Allup\wwwroot\assets\images\";

                    string path = Path.Combine(_env.WebRootPath, "assets", "images");

                    if (System.IO.File.Exists((path + existedCategory.Image)))
                    {
                        System.IO.File.Delete((path + existedCategory.Image));
                    } 

                    string fileName = Guid.NewGuid().ToString() + "-" + DateTime.UtcNow.AddHours(4)
                    .ToString("yyyyMMddHHmmss") + "-" + category.File.FileName;

                    //string fullpath = path + fileName;

                    string fullpath = Path.Combine(path, fileName);

                    using (FileStream fileStream = new FileStream(path, FileMode.Create))
                    {
                        await category.File.CopyToAsync(fileStream);
                    }

                    existedCategory.Image = fileName;
                    existedCategory.ParentId = null;
                }
            }
            else
            {
                if (category.ParentId == null)
                {
                    ModelState.AddModelError("ParentId", "Ust category mutleq secilmelidir !");
                    return View(category);
                }

                if (await _context.Categories.AnyAsync(c => c.IsDeleted == false && c.IsMain && c.Id == category.ParentId))
                {
                    ModelState.AddModelError("ParentId", "Duzgun ust category sec !");
                    return View(category);
                }

                existedCategory.Image = null;
                existedCategory.ParentId = category.ParentId;
            }

            existedCategory.IsMain = category.IsMain;
            existedCategory.Name = category.Name.Trim();
            existedCategory.UpdatedAt = DateTime.UtcNow.AddHours(4);
            existedCategory.UpdatedBy = "System";

            await _context.SaveChangesAsync();
            return RedirectToAction("Index");
        }

        [HttpGet]
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null) return BadRequest("Id bos ola bilmez !");

            Category category = await _context.Categories
              .Include(c => c.Products)
              .Include(c => c.Children)
              .FirstOrDefaultAsync(c => c.IsDeleted == false && c.Id == id);

            if (category == null) return NotFound("Id sehvdir");

            if ((category.Products != null && category.Products.Count() > 0) 
            || (category.Children != null && category.Children.Count() > 0))
            {
                TempData["Error"] = $"Bu category'de {id} Id siline bilmez";

                return RedirectToAction("Index");
            }

            category.IsDeleted = true;
            category.DeletedAt = DateTime.UtcNow.AddHours(4);
            category.DeletedBy = "System";

            await _context.SaveChangesAsync();
            return RedirectToAction("Index");
        }


        public async Task<ActionResult> Detail(int? id)
        {
            if (id == null) return BadRequest("Id bos ola bilmez !");

            Category category = await _context.Categories
                .Include(c=>c.Products)
                .Include(c=>c.Children)
                .FirstOrDefaultAsync(c => c.IsDeleted == false && c.IsMain && c.Id == id);

            if (category == null) return NotFound("Daxil edilen Id yanlisdir");

            return View(category);
        }
    }
}
