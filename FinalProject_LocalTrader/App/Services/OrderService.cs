using App.Context;
using App.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace App.Services
{
    public class OrderService
    {
        private readonly EFContext context;
        public OrderService(EFContext _context)
        {
            context = _context;
        }
        public List<OrderModel> GetAll()
        {
            List<OrderModel> orders = new List<OrderModel>();
            try
            {
                orders = context.Orders.ToList();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.InnerException);
            }
            return orders;
        }
        public OrderModel GetOne(int id)
        {
            OrderModel order;
            try
            {
                order = context.Orders
                   .Where(x => x.Id == id)
                   .Include(x => x.ProductOrder)
                   .ThenInclude(x => x.Product)
                   .First();
                return order;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.InnerException);
            }
            return null;
        }

        public OrderModel FinishOrder(int id)
        {
            OrderModel order = GetOne(id);
            order.Status = "Active";
            context.Orders.Update(order);
            context.SaveChanges();
            return order;
        }
    }
}
