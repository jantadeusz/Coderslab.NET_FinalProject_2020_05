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

namespace App.Controllers
{
    public class ImageController : Controller
    {
        private IWebHostEnvironment _env;
        public ImageController(IWebHostEnvironment env)
        {
            _env = env;
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
                var fileList = Request.Form.Files;
                if (fileList != null && fileList.Count > 0)
                {
                    var webRoot = _env.WebRootPath;
                    var file = fileList[0];
                    //var fileName = Path.GetFileName(file.FileName);//file.FileName;
                    //string path = Path.Combine();
                    //string filePath = Path.Combine(Server.MapPath("~/FilesUpload"), fileName);
                    var newPath = Path.Combine(webRoot, file.FileName);
                    var stream = new FileStream(newPath, FileMode.Create);

                    file.CopyTo(stream);

                }                    //file.SaveAs(newPath);

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return View();
        }
    }
}