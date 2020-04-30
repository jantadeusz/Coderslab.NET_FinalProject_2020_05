using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace App.Models
{
    public class ProductOrderModel
    {
        [Key]
        public int Id { get; set; }
        public int ProductID { get; set; }
        [ForeignKey("ProductID")]
        public ProductModel Product { get; set; }
        public int ProductQuantity { get; set; }
        public int OrderID { get; set; }
        [ForeignKey("OrderID")]
        public OrderModel Order { get; set; }
    }
}
