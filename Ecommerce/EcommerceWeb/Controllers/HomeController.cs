using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using EcommerceWeb.Models;

namespace EcommerceWeb.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()// action methods 
        {
            List<Product> products = new List<Product>();
            products.Add(new Product { Id = 1, Name = "Jaya", Description = "Flower", Price = 23, Quantity = 12,Url = "/Images/rose.jfif" });
            products.Add(new Product { Id = 2, Name = "Jasmine", Description = "Flower Grey ", Price = 23554, Quantity = 32 });
            products.Add(new Product { Id = 3, Name = "Rose", Description = "Flower Black", Price = 2323, Quantity = 22 });
            
            return View(products);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}