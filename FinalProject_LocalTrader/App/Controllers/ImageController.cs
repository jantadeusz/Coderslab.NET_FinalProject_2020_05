using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using App.Models;
using App.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Hosting.Internal;
using System.Web;
using Microsoft.AspNetCore.Hosting;
using App.Services;
using App.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion.Internal;

namespace App.Controllers
{
    public class ImageController : Controller
    {
        private readonly IWebHostEnvironment Env;
        public EFContext Context;
        public ImageController(IWebHostEnvironment env, EFContext context)
        {
            Env = env;
            Context = context;
        }
        [HttpGet]
        public IActionResult Add(int id)
        {
            ViewData["productId"] = id;
            return View();
        }
        [HttpPost]
        public IActionResult Add([FromForm]string productId)
        {
            try
            {
                int prodId = Int32.Parse(productId);
                var fileList = Request.Form.Files;
                if (fileList != null && fileList.Count > 0)
                {
                    var webRoot = Env.WebRootPath;
                    var file = fileList[0];
                    //var path = $"{webRoot}\\Images\\{productId}___{file.FileName.Replace(' ','_')}";
                    var pathToCopy = $".\\wwwroot\\Images\\{productId}___{file.FileName.Replace(' ', '_')}";
                    var stream = new FileStream(pathToCopy, FileMode.Create);
                    file.CopyTo(stream);

                    ProductService ps = new ProductService(Context);
                    ImageModel image = new ImageModel()
                    {
                        FilePath = $"Images\\{productId}___{file.FileName.Replace(' ', '_')}",
                        ProductId = prodId,
                        Product = ps.GetOne(prodId)
                    };
                    Context.Images.Add(image);
                    Context.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return RedirectToAction("MyProduction","Product");
        }
        /*
        [HttpPost]
        public async Task<IActionResult> Add2([FromForm]string productId)
        {
            try
            {
                int prodId = Int32.Parse(productId);
                var memoryStream = new MemoryStream();
                var fileList = Request.Form.Files;
                if (fileList != null && fileList.Count > 0)
                {
                    var myFile = fileList[0];
                    await myFile.CopyToAsync(memoryStream);
                    if (memoryStream.Length < 2097152) // Upload the file if less than 2 MB 
                    {
                        ProductService ps = new ProductService(Context);
                        Image2Model image = new Image2Model()
                        {
                            Content = memoryStream.ToArray(),
                            ProductId = prodId,
                            Product = ps.GetOne(prodId)
                        };
                        Context.Images2.Add(image);
                        //var file = new AppFile() { Content = memoryStream.ToArray() };
                        await Context.SaveChangesAsync();
                    }
                    else
                    {
                        ModelState.AddModelError("File", "The file is too large.");
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return View();
        }
         */
    }
}
