using Microsoft.AspNetCore.SignalR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace App.Models
{
    public class OrderModel
    {
        public int Id { get; set; }
        public string Status { get; set; }
        public ConsumerModel Consumer { get; set; }
        public DateTime OrderStart { get; set; }
        public DateTime OrderEnd { get; set; }
        public ICollection<ProductOrderModel> ProductOrder { get; set; }
    }
}
