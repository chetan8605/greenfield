using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Catalogue;

namespace EcommerceWeb.Controllers
{
    public class ProductsController : Controller
    {
        // GET: Products
        public ActionResult Index()
        {
            IProductService svc = new ProductService();
            List<Product> products = svc.GetAll();
            //List<Product> products = new List<Product>();
            //products.Add(new Product { Id = 1, Name = "Jaya", Description = "Flower", Price = 23, Quantity = 12, Url = "/Images/rose.jfif" });
            //products.Add(new Product { Id = 2, Name = "Jasmine", Description = "Flower Grey ", Price = 23554, Quantity = 32,Url = "/Images/rose.jfif" });
            //products.Add(new Product { Id = 3, Name = "Rose", Description = "Flower Black", Price = 2323, Quantity = 22, Url = "/Images/rose.jfif" });

            return View(products);
            
        }
        
        public ActionResult Details() 
        {
            return View();
                }
        public ActionResult Insert() 
        { 
            return View();
        }
        public ActionResult Update()
        {
            return View();
        }
        public ActionResult Delete() 
        {
            return View();    
        }
    }
}