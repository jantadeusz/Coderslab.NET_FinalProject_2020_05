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
            OrderModel order = new OrderModel();
            order.Status = "Open";
            order.OrderStart = DateTime.Now;
            Context.Orders.Add(order);
            Context.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Edit(int id)
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
        public IActionResult AddProductToOrder(ProductOrderModel prodOrdFromForm)
        {
            if (ModelState.IsValid && prodOrdFromForm.ProductQuantity > 0)
            {
                Service.AddProductToOrder(prodOrdFromForm);
                return RedirectToAction("Edit", new { id = prodOrdFromForm.OrderID });
            }
            else { ViewData["Error"] = "Błędy w formularzu"; }
            return View(prodOrdFromForm);
        }

        [HttpGet]
        public IActionResult RemoveProductFromOrder(int id, int id1)
        {
            // objaśnienie: 
            // id = order.Id; id1 = productOrder.Id
            var productOrder = Context.ProductsOrders.FirstOrDefault(x => x.Id == id1);
            Context.ProductsOrders.Remove(productOrder);
            Context.SaveChanges();
            return RedirectToAction("Edit", new { id });
        }

        [HttpGet]
        public IActionResult FinishOrder(int id)
        {
            Service.FinishOrder(id);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Remove(int id)
        {
            var order = Service.GetOne(id);
            return View(order);
        }
        [HttpGet]
        public IActionResult RemoveConfirm(int id)
        {
            Service.Remove(id);
            return RedirectToAction("Index");
        }
    }
}