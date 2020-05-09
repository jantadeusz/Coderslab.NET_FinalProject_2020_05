using App.Context;
using App.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

namespace App.Services
{
    public class ProductService
    {
        private readonly EFContext context;
        public ProductService(EFContext _context)
        {
            context = _context;
        }
        public void Add(ProductModel product)
        {
            try
            {
                context.Products.Add(product);
                /*
                if(product.ProductImage != null)
                {
                    context.ProductImage.Add(product.ProductImage);
                }
                 */
                context.SaveChanges();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
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
                context.Products.Update(product);
                context.SaveChanges();
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
                var actor = context.Products.SingleOrDefault(x => x.Id == id);
                context.Products.Remove(actor);
                context.SaveChanges();
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
                product = context.Products
                   .Where(x => x.Id == id)
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
                products = context.Products
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
