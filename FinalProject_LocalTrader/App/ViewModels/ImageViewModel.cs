using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

namespace App.ViewModels
{
    public class ImageViewModel
    {
        public int ProductId { get; set; }
        public IFormFile ImageFile { get; set; }
        public string Test { get; set; }
    }
}
