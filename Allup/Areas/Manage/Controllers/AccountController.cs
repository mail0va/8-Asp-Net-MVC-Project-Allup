using Allup.Areas.Manage.ViewModels;
using Allup.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Allup.Areas.Manage.Controllers
{
    [Area("manage")]
    public class AccountController : Controller
    {
        private readonly RoleManager<IdentityRole> _roleManager;
        private readonly UserManager<AppUser> _userManager;
        private readonly SignInManager<AppUser> _signInManager;

        public AccountController
           (
            RoleManager<IdentityRole> roleManager,
            UserManager<AppUser> userManager,
            SignInManager<AppUser> signInManager
            )
        {
            _roleManager = roleManager;
            _userManager = userManager;
            _signInManager = signInManager;
        }
        //public IActionResult Index()
        //{
        //    return View();
        //}
        [HttpGet]
        public IActionResult Register()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Register(RegisterVM registerVM)
        {
            if (!ModelState.IsValid) return View(registerVM);
            AppUser appUser = new AppUser
            {
                Name = registerVM.Name,
                Email = registerVM.Email,
                UserName = registerVM.UserName
            };

            if (await _userManager.Users.AnyAsync(u=>u.NormalizedUserName==registerVM.UserName.Trim().ToUpperInvariant()))
            {
                ModelState.AddModelError("UserName","Already exists");
                return View(registerVM);
            }
            if (await _userManager.Users.AnyAsync(u=>u.NormalizedEmail==registerVM.Email.Trim().ToUpperInvariant()))
            {
                ModelState.AddModelError("Email","Already exists");
                return View(registerVM);
            }
            //await _userManager.CreateAsync(appUser,registerVM.Password);
            IdentityResult identityResult = await _userManager.CreateAsync(appUser, registerVM.Password);

            if (!identityResult.Succeeded)
            {
                foreach (var item in identityResult.Errors)
                {
                    ModelState.AddModelError("",item.Description);
                }
                return View(registerVM);
            }
            await _userManager.AddToRoleAsync(appUser, "Admin");
            return RedirectToAction("Index", "Dashboard", new { area = "manage" });
        }

        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Login(LoginVM loginVM)
        {
            if(!ModelState.IsValid) return View(loginVM);

            AppUser appUser = await _userManager.FindByEmailAsync(loginVM.Email);

            if (appUser==null)
            {
                ModelState.AddModelError("","Daxil etdiyiniz Email ve ya Sifre yanlisdir");
                return View(loginVM);
            }

            //await _signInManager.CheckPasswordSignInAsync(appUser,loginVM.Password,true);

            //Microsoft.AspNetCore.Identity.SignInResult signInResult = 
            //await _signInManager.CheckPasswordSignInAsync(appUser,loginVM.Password,true);

            //if (!signInResult.Succeeded)
            //{
            //    ModelState.AddModelError("", "Daxil etdiyiniz Email ve ya Sifre yanlisdir");
            //    return View(loginVM);
            //}

            Microsoft.AspNetCore.Identity.SignInResult signInResult =
            await _signInManager.PasswordSignInAsync(appUser,loginVM.Password,loginVM.RemindMe,true);

            //if (!signInResult.Succeeded)
            //{ ?????????????????????
            //    if (signInResult.IsLockedOut)
            //    {
            //        ModelState.AddModelError("", appUser.AccessFailedCount.ToString());
            //        return View(loginVM);
            //    }
            //}
            return RedirectToAction("Index", "Dashboard", new { area = "manage" });
        }

        //public async Task<IActionResult> CreateSuperAdmin()
        //{
        //    AppUser appUser = new AppUser
        //    {
        //        Email="superadmin@code.edu.az",
        //        Name="Super",
        //        UserName="SuperAdmin"
        //    };
        //    await _userManager.CreateAsync(appUser);
        //    await _userManager.AddPasswordAsync(appUser,"SuperAdmin@123");
        //    await _userManager.AddToRoleAsync(appUser,"SuperAdmin");
        //}

        //public async Task<IActionResult> CreateRole()
        //{
        //    await _roleManager.CreateAsync(new IdentityRole {Name="SuperAdmin" });
        //    await _roleManager.CreateAsync(new IdentityRole {Name="Admin" });
        //    await _roleManager.CreateAsync(new IdentityRole {Name="Member" });

        //    return Ok();
        //}
    }
}
