using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using App.Context;
using App.Models;
using App.ViewModels;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace App.Controllers
{
    public class ConsumerController : Controller
    {
        private readonly SignInManager<ConsumerModel> signInManager;
        private readonly UserManager<ConsumerModel> userManager;
        private readonly EFContext Context;
        public ConsumerController(
            SignInManager<ConsumerModel> _signInManager,
            UserManager<ConsumerModel> _userManager,
            EFContext context)
        {
            signInManager = _signInManager;
            userManager = _userManager;
            Context = context;
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
                var consumer = new ConsumerModel()
                {
                    UserName = registerView.UserName,
                    Email = registerView.Email,
                    BirthDate = registerView.BirthDate,
                    DateAdded = DateTime.Now
                };
                var result = await userManager.CreateAsync(consumer, registerView.Password);
                if (result.Succeeded)
                {
                    var address = new AddressModel()
                    {
                        ConsumerId = consumer.Id,
                        Latitude = registerView.Latitude,
                        Longitude = registerView.Longitude,
                        Elevation = registerView.Elevation
                    };
                    Context.Addresses.Add(address);
                    Context.SaveChanges();
                    return RedirectToAction("RegisterSuccess");
                }
                ModelState.AddModelError("", "Niepoprawne dane");
                foreach (var error in result.Errors)
                {
                    ModelState.AddModelError("", error.Description);
                }
            }
            return View(registerView);
        }

        public IActionResult RegisterSuccess()
        {
            return View();
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