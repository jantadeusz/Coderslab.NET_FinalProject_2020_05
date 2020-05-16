using App.Context;
using App.Models;
using App.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace App.Services
{
    public class ProductService
    {
        private readonly EFContext Context;
        public ProductService(EFContext _context)
        {
            Context = _context;
        }
        public ProductModel Add(ProductViewModel productView)
        {
            ProductModel product = null;
            try
            {
                product = new ProductModel()
                {
                    Name = productView.ProductName,
                    Price = productView.Price,
                    Description = productView.Description,
                    Category = Context.Categories.Where(x => x.Id == productView.CategoryId).First(),
                };
                Context.Products.Add(product);
                Context.SaveChanges();
            }
            catch (Exception ex) { Console.WriteLine(ex.Message + "\n" + ex.InnerException); }
            return product;
        }
        public void Update(ProductModel productFromForm)
        {
            try
            {
                int idToUpdate = productFromForm.Id;
                var product = GetOne(idToUpdate);
                product.Name = productFromForm.Name;
                product.Description = productFromForm.Description;
                product.Price = productFromForm.Price;
                Context.Products.Update(product);
                Context.SaveChanges();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.InnerException);
            }
        }
        public void Remove(int id)
        {
            try
            {
                var actor = Context.Products.SingleOrDefault(x => x.Id == id);
                Context.Products.Remove(actor);
                Context.SaveChanges();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.InnerException);
            }
        }
        public ProductModel GetOne(int id)
        {
            ProductModel product;
            try
            {
                product = Context.Products
                   .Where(x => x.Id == id)
                   .Include(x => x.Category)
                   .Include(x => x.ProductOrder).ThenInclude(x => x.Order)
                   .Include(x => x.Image)
                   .First();
                return product;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.InnerException);
            }
            return null;
        }
        public List<ProductModel> GetAll()
        {
            List<ProductModel> products = new List<ProductModel>();
            try
            {
                products = Context.Products
                    .Include(x => x.Category)
                    .Include(x => x.ProductOrder).ThenInclude(x => x.Order)
                    .Include(x => x.Image)
                    .ToList();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.InnerException);
            }
            return products;
        }
    }
}
