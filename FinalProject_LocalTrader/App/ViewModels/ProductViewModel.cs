using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace App.ViewModels
{
    public class ProductViewModel
    {
        [Required]
        public int CategoryId { get; set; }
        [Required]
        public string ProductName { get; set; }
        [Required]
        public string Description { get; set; }
        [Required]
        [Column(TypeName = "decimal(18,2)")]
        public decimal Price { get; set; }
        //[Required]
        //public IFormFile ImageFile { get; set; }
    }
}
