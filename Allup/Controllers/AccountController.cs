using Allup.Models;
using Allup.ViewModels;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Allup.Controllers
{
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
        [AutoValidateAntiforgeryToken]
        public async Task<IActionResult> Register(CRegisterVM cRegisterVM)
        {
            if (!ModelState.IsValid) return View();

            AppUser appUser = new AppUser
            {
                Name = cRegisterVM.Name,
                UserName = cRegisterVM.UserName,
                Email = cRegisterVM.Email,
            };
            appUser.IsActive = true;
            IdentityResult identityResult = await _userManager.CreateAsync(appUser, cRegisterVM.Password);

            if (!identityResult.Succeeded)
            {
                foreach (var error in identityResult.Errors)
                {
                    ModelState.AddModelError("", error.Description);
                }
                return View();
            }
            return RedirectToAction("Index", "Home");
        }

        [HttpGet]
        public IActionResult Login()
        {
            if (User.Identity.IsAuthenticated)
            {
                return RedirectToAction("Index", "Home");
            }
            return View();
        }
        public async Task<IActionResult> Login(CLoginVM cLoginVM)
        {
            if (!ModelState.IsValid) return View();

            AppUser dbUser = await _userManager.FindByEmailAsync(cLoginVM.Email);

            if (dbUser == null)
            {
                ModelState.AddModelError("", "Daxil etdiyiniz email ve ya sifre sehvdir");
                return View();
            }

            var signInResult = await _signInManager.PasswordSignInAsync(dbUser, cLoginVM.Password, true, true);

            if (dbUser.IsActive == false)
            {
                ModelState.AddModelError("", "User deactive");
                return View();
            }

            //if (signInResult.IsLockedOut)
            //{
            //    ModelState.AddModelError("", "is Lockout");
            //    return View();
            //}

            if (!signInResult.Succeeded)
            {
                ModelState.AddModelError("", "email ve ya sifre sehvdir ");
                return View();
            }

            var roles = await _userManager.GetRolesAsync(dbUser);

            if (roles[0] == "SuperAdmin")
            {
                return RedirectToAction("Index", "Dashboard", new { area = "manage" });
            }
            return RedirectToAction("Index", "Home");
        }

    }
}
