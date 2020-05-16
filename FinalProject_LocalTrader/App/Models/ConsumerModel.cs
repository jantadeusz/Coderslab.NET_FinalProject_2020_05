using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace App.Models
{
    public class ConsumerModel:IdentityUser
    {
        //zawodowypolak
        //https://stackoverflow.com/questions/40532987/how-to-extend-identityuser-with-custom-property/40579369
        [Required]
        public DateTime BirthDate { get; set; }
        public AddressModel Address { get; set; }
        public DateTime DateAdded { get; set; }
        public DateTime? DateUpdated { get; set; }
        public ICollection<OrderModel> Orders { get; set; }
    }
}
