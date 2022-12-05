using Allup.DAL;
using Allup.Interfaces;
using Allup.Models;
using Allup.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Allup.Services
{
    public class LayoutServices : ILayoutService
    {
        private readonly AppDbContext _context;
        private readonly IHttpContextAccessor _httpContextAccessor;

        public LayoutServices(AppDbContext context, IHttpContextAccessor httpContextAccessor)
        {
            _context = context;
            _httpContextAccessor = httpContextAccessor;
        }

        public async Task<IEnumerable<BasketVM>> GetBasketAsync()
        {
            string basket = _httpContextAccessor.HttpContext.Request.Cookies["basket"];
            List<BasketVM> basketVMs = null;

            if (!string.IsNullOrWhiteSpace(basket))
            {
                basketVMs = JsonConvert.DeserializeObject<List<BasketVM>>(basket);
            }
            else
            {
                basketVMs = new List<BasketVM>();
            }
            foreach (BasketVM basketVM in basketVMs)
            {
                Product product = await _context.Products.FirstOrDefaultAsync(p => p.Id == basketVM.Id && p.IsDeleted == false);

                basketVM.Title = product.Title;
                basketVM.Image = product.MainImage;
                basketVM.ExTax = product.ExTax;
                basketVM.Price = product.DiscountPrice > 0 ? product.DiscountPrice : product.Price;
            }
            return basketVMs;
        }

        public async Task<IEnumerable<Category>> GetCategoriesAsync()
        {
            return await _context.Categories.Include(c => c.Children).Where(c => c.IsDeleted == false && c.IsMain).ToListAsync();
        }

        public async Task<Dictionary<string, string>> GetSettingAsync()
        {
            return await _context.Settings.ToDictionaryAsync(s => s.Key, s => s.Value);
        }

    }
}
