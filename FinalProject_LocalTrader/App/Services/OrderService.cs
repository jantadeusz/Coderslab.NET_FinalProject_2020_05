using App.Context;
using App.Models;
using Microsoft.AspNetCore.Identity;
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
        public List<OrderModel> GetAll(string consumerId)
        {

            List<OrderModel> orders = new List<OrderModel>();
            try
            {
                orders = context.Orders
                    .Where(x => x.Consumer.Id == consumerId)
                    .Include(x => x.Consumer)
                    .Include(x => x.ProductOrder).ThenInclude(x => x.Product)
                    .ToList();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.InnerException);
            }
            return orders;
        }

        public OrderModel GetOne(int orderId)
        {
            OrderModel order;
            try
            {
                order = context.Orders
                   .Where(x => x.Id == orderId)
                   .Include(x=> x.Consumer)
                   .Include(x => x.ProductOrder).ThenInclude(x => x.Product)
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
            order.Status = "InDelivery";
            order.OrderEnd = DateTime.Now;
            context.Orders.Update(order);
            context.SaveChanges();
            return order;
        }

        public void AddProductToOrder(ProductOrderModel productOrder)
        {
            productOrder.Id = 0; // trzeba wyzerowac zeby dzialalo, bo wali bledem inaczej
            ProductOrderModel prodOrdFromDB = null;
            try
            {
                prodOrdFromDB = context.ProductsOrders
                    .Where(x => x.ProductID == productOrder.ProductID)
                    .Where(x => x.OrderID == productOrder.OrderID).First();
            }
            catch (Exception ex) { Console.WriteLine(ex.Message); }
            if (prodOrdFromDB == null)
            {
                ProductService ps = new ProductService(context);
                productOrder.Product = ps.GetOne(productOrder.ProductID);
                productOrder.Order = GetOne(productOrder.OrderID);
                context.ProductsOrders.Add(productOrder);
            }
            else
            {
                prodOrdFromDB.ProductQuantity += productOrder.ProductQuantity;
                context.ProductsOrders.Update(prodOrdFromDB);
            }
            context.SaveChanges();
        }

        public void Remove(int id)
        {
            var order = context.Orders.Where(x => x.Id == id).First();
            context.Orders.Remove(order);
            context.SaveChanges();
        }
    }
}
