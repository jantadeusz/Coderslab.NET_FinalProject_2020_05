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
    public class CategoryController : Controller
    {
        private readonly EFContext Context;
        public CategoryController(EFContext context)
        {
            Context = context;
        }

        public IActionResult Index()
        {
            var categories = Context.Categories.ToList();
            return View(categories);
        }

        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Add(CategoryModel category)
        {
            if (ModelState.IsValid)
            {
                Context.Categories.Add(category);
                Context.SaveChanges();
                return RedirectToAction("Index");
            }
            else { return View(category); }
        }

        [HttpGet]
        public IActionResult Remove(int id)
        {
            var category = Context.Categories.FirstOrDefault(x => x.Id == id);
            Context.Categories.Remove(category);
            Context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}