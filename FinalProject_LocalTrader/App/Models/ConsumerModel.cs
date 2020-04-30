using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace App.Models
{
    public class ConsumerModel
    {
        public int Id { get; set; }
        [Required]
        public string Nick { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        public DateTime BirthDate { get; set; }
        public AddressModel Address { get; set; }
        public DateTime DateAdded { get; set; }
        public DateTime? DateUpdated { get; set; }
        public ICollection<OrderModel> Orders { get; set; }
    }
}
