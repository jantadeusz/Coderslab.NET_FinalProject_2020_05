using App.Context;
using App.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace App.Services
{
    public class CategoryService
    {
        private readonly EFContext Context;
        public CategoryService(EFContext context)
        {
            Context = context;
        }
        public List<CategoryModel> GetAll()
        {
            List<CategoryModel> categories = new List<CategoryModel>();
            try { categories = Context.Categories.ToList(); }
            catch (Exception ex) { Console.WriteLine(ex.Message + "\n" + ex.InnerException); }
            return categories;
        }
    }
}
