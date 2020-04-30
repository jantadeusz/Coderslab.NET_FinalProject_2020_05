using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace App.Models
{
    public class ProducerModel
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public AddressModel Address { get; set; }
        public ICollection<ProductModel> Products { get; set; }

        // trzeba zrobic tak zeby konsument na zyczenie stawal sie producentem
    }
}
