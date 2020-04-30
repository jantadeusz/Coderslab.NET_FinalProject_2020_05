using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using App.Context;
using App.Models;
using App.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace App.Controllers
{
    public class OrderController : Controller
    {
        private OrderService Service { get; }
        public EFContext Context { get; }
        public OrderController(EFContext context, OrderService service)
        {
            Context = context;
            Service = service;
        }
        public IActionResult Index()
        {
            var orders = Service.GetAll();
            return View(orders);
        }

        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Add(OrderModel order)
        {
            if (ModelState.IsValid)
            {
                order.Status = "Open";
                order.OrderStart = DateTime.Now;
                Context.Orders.Add(order);
                Context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(order);
        }

        [HttpGet]
        public IActionResult ShowOrder(int id)
        {
            var order = Service.GetOne(id);
            return View(order);
        }

        [HttpGet]
        public IActionResult AddProductToOrder(int id)
        {
            ProductOrderModel productOrderModel = new ProductOrderModel()
            {
                OrderID = id
            };
            return View(productOrderModel);
        }
        [HttpPost]
        public IActionResult AddProductToOrder(ProductOrderModel productOrder)
        {
            if (ModelState.IsValid)
            {
                productOrder.Id = 0;
                ProductService ps = new ProductService(Context);
                productOrder.Product = ps.GetOne(productOrder.ProductID);
                productOrder.Order = Service.GetOne(productOrder.OrderID);
                Context.ProductsOrders.Add(productOrder);
                Context.SaveChanges();
                return RedirectToAction("ShowOrder", new { id = productOrder.OrderID });
            }
            return View(productOrder);
        }

        [HttpGet]
        public IActionResult RemoveProductFromOrder(int id, int id1)
        {
            // objaśnienie: 
            // id = order.Id; id1 = productOrder.Id
            var productOrder = Context.ProductsOrders.FirstOrDefault(x => x.Id == id1);
            Context.ProductsOrders.Remove(productOrder);
            Context.SaveChanges();
            return RedirectToAction("ShowOrder", new { id });
        }
        
        [HttpGet]
        public IActionResult FinishOrder(int id)
        {
            Service.FinishOrder(id);
            return RedirectToAction("Index");
        }
    }
}