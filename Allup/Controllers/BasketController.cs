using Allup.DAL;
using Allup.Models;
using Allup.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Allup.Controllers
{
    public class BasketController : Controller
    {
        private readonly AppDbContext _context;
        public BasketController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            return View();
        }

        public async Task<IActionResult> AddToBasket(int? id)
        {
            if (id == null) return BadRequest("Id null ola bilmez !!!");

            //Product product = await _context.Products.FirstOrDefaultAsync(p => p.IsDeleted == false && p.Id == id);

            if (!await _context.Products.AnyAsync(p => p.IsDeleted == false && p.Id == id)) return NotFound("Id yalnisdir !");

            string basket = HttpContext.Request.Cookies["basket"];
            List<BasketVM> products = null;

            if (!string.IsNullOrWhiteSpace(basket))
            {
                products = JsonConvert.DeserializeObject<List<BasketVM>>(basket);
                BasketVM basketVM = products.Find(p => p.Id == id);
                if (basketVM != null)
                {
                    basketVM.Count += 1;
                }
                else
                {
                    basketVM = new BasketVM
                    {
                        Id = (int)id,
                        Count = 1
                    };
                    products.Add(basketVM);
                }
            }
            else
            {
                products = new List<BasketVM>();

                BasketVM basketVM = new BasketVM
                {
                    Id = (int)id,
                    Count = 1
                };
                products.Add(basketVM);
            }

            basket = JsonConvert.SerializeObject(products);
            HttpContext.Response.Cookies.Append("basket", basket);

            foreach (BasketVM basketVM in products)
            {
                Product product = await _context.Products.FirstOrDefaultAsync(p => p.Id == basketVM.Id && p.IsDeleted == false);

                basketVM.Title = product.Title;
                basketVM.Image = product.MainImage;
                basketVM.ExTax = product.ExTax;
                basketVM.Price = product.DiscountPrice > 0 ? product.DiscountPrice : product.Price;
            }

            return PartialView("_BasketCartPartial", products);
        }

        public IActionResult GetFromBasket()
        {
            string basket = HttpContext.Request.Cookies["basket"];

            List<BasketVM> products = JsonConvert.DeserializeObject<List<BasketVM>>(basket);

            return Json(products);
        }

        public async Task<IActionResult> DeleteFromBasket(int? id)
        {
            if (id == null) return BadRequest("Id null ola bilmez !!!");

            if (!await _context.Products.AnyAsync(p => p.Id == id)) return NotFound();

            string cookieBasket = HttpContext.Request.Cookies["basket"];

            List<BasketVM> basketVMs = null;
            if (cookieBasket != null)
            {
                basketVMs = JsonConvert.DeserializeObject<List<BasketVM>>(cookieBasket);

                if (!basketVMs.Any(b => b.Id == id))
                {
                    return NotFound();
                }
                BasketVM basketVM = basketVMs.FirstOrDefault(b => b.Id == id);
                basketVMs.Remove(basketVM);
            }
            else
            {
                basketVMs = new List<BasketVM>();
            }
            cookieBasket = JsonConvert.SerializeObject(basketVMs);
            HttpContext.Response.Cookies.Append("basket", cookieBasket);
            foreach (BasketVM basketVM in basketVMs)
            {
                Product product = await _context.Products.FirstOrDefaultAsync(p => p.Id == basketVM.Id && p.IsDeleted == false);
                //Product product = await _context.Products.FirstOrDefaultAsync(p => p.Id == basketVM.Id);
                basketVM.Title = product.Title;
                basketVM.Image = product.MainImage;
                basketVM.ExTax = product.ExTax;
                basketVM.Price = product.DiscountPrice > 0 ? product.DiscountPrice : product.Price;
            }
            return PartialView("_BasketCartPartial", basketVMs);
        }
    }
}
