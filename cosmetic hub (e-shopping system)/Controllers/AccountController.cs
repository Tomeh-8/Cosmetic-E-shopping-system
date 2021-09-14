using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using cosmetic_hub__e_shopping_system_.Models;
using cosmetic_hub__e_shopping_system_.ViewModels;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace cosmetic_hub__e_shopping_system_.Controllers
{
    public class AccountController : Controller
    {
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly SignInManager<ApplicationUser> _signInManager;

        public AccountController(UserManager<ApplicationUser> userManager, SignInManager<ApplicationUser> signInManager)
        {
            _userManager = userManager;
            _signInManager = signInManager;
        }

        [HttpGet]
        public IActionResult Login(string returnUrl)
        {
            LoginViewModel login = new LoginViewModel
            {
                ReturnUrl = returnUrl
            };

            return View(login);
        }

        [HttpPost]
        public async Task<IActionResult> Login(LoginViewModel model)
        {
            if (ModelState.IsValid)
            {
                var result = await _signInManager.PasswordSignInAsync(model.UserName , model.Password, false, false);
                if (result.Succeeded)
                {
                    return RedirectToAction("ProductList", "Product");
                }

                ModelState.AddModelError(string.Empty, "Login Failed");
            }

            return View(model);
        }

        [HttpGet]
        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Register(RegisterViewModel model)
        {
            if (ModelState.IsValid)
            {
                var user = new ApplicationUser
                {
                    Email = model.Email,
                    UserName = model.UserName
                };

                var data = await _userManager.CreateAsync(user, model.Password);
                if (data.Succeeded)
                {
                    await _signInManager.SignInAsync(user, isPersistent: false);
                    return RedirectToAction("ProductList", "Product");
                }

                foreach (var error in data.Errors)
                {
                    ModelState.AddModelError(string.Empty, error.Description);
                }
            }

            return View(model);
        }

    }
}
