using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace App.ViewModels
{
    public class RegisterViewModel
    {
        [Required]
        public string UserName { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        public string Password { get; set; }
        [Required]
        [Compare("Password")]
        public string RepeatPassword { get; set; }
        [Required]
        public DateTime BirthDate { get; set; }
        [Required]
        public string Longitude { get; set; } 
        [Required]
        public string Latitude { get; set; } 
        [Required]
        [Column(TypeName = "decimal(18,2)")]
        public decimal Elevation { get; set; }
    }
}
