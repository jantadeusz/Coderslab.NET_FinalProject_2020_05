using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using App.ViewModels;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace App.Controllers
{

    public class AccountController : Controller
    {
        private readonly SignInManager<IdentityUser> signInManager;
        private readonly UserManager<IdentityUser> userManager;
        public AccountController(
            SignInManager<IdentityUser> _signInManager, UserManager<IdentityUser> _userManager)
        {
            signInManager = _signInManager;
            userManager = _userManager;
        }

        [HttpGet]
        public IActionResult Register()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Register(RegisterViewModel registerView)
        {
            if (ModelState.IsValid)
            {
                var user = new IdentityUser(registerView.Login) { Email = registerView.Email };
                var result = await userManager.CreateAsync(user, registerView.Password);
                if (result.Succeeded)
                {
                    return RedirectToAction("Index", "Home");
                    //return RedirectToAction("AddUserToRoleConsument", "Role");
                }
                ModelState.AddModelError("", "Niepoprawne dane");
                foreach (var error in result.Errors)
                {
                    ModelState.AddModelError("", error.Description);
                }
            }
            return View(registerView);
        }

        [HttpGet]
        public IActionResult LogIn()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Login(LoginViewModel viewModel)
        {
            if (ModelState.IsValid)
            {
                var resultLogin = await signInManager.PasswordSignInAsync(
                    viewModel.Login, viewModel.Password, true, false);
                if (resultLogin.Succeeded)
                {
                    return RedirectToAction("Index", "Home");
                }
                ModelState.AddModelError("", "Nie można się zalogować!");
            }
            return View(viewModel);
        }
        [HttpGet]
        public async Task<IActionResult> LogOut()
        {
            await signInManager.SignOutAsync();
            return RedirectToAction("Index", "Home");
        }
    }
}