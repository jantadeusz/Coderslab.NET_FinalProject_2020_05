using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using App.Context;
using App.Models;
using App.Services;
using Microsoft.AspNetCore.Mvc;

namespace App.Controllers
{
    public class ProductController : Controller
    {
        private ProductService Service { get; }
        public EFContext Context { get; }
        public ProductController(EFContext context, ProductService service)
        {
            Context = context;
            Service = service;
        }
        public IActionResult Index()
        {
            var products = Service.GetAll();
            return View(products);
        }
        public IActionResult MyProduction()
        {           
            var products = Service.GetAll();
            return View(products);
        }
        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Add(ProductModel product)
        {
            if (ModelState.IsValid)
            {
                Service.Add(product);
                return RedirectToAction("Index");
            }
            else { return View(product); }
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            var product = Service.GetOne(id);
            return View(product);
        }
        [HttpPost]
        public IActionResult Edit(ProductModel product)
        {
            if (ModelState.IsValid)
            {
                Service.Update(product);
                return RedirectToAction("Index");
            }
            else { return View(product); }
        }

        [HttpGet]
        public IActionResult Remove(int id)
        {
            var product = Service.GetOne(id);
            return View(product);
        }
        [HttpGet]
        public IActionResult RemoveConfirmation(int id)
        {
            Service.Remove(id);
            return RedirectToAction("Index");
        }
    }
}