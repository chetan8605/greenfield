using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Catalogue;
using CRM;
using OrderProcessing;

namespace EcommerceTest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * For Customer
             * 
            Customer customer = new Customer();
            customer.Id = 22;
            customer.FirstName = "Chetan";
            customer.LastName = "More";
            customer.Email = "chetanmore@gmail.com";

            Customer customer1 = new Customer();
            customer1.Id = 23;
            customer1.FirstName = "Raj";
            customer1.LastName = "Awate";
            customer1.Email = "rajawate1307@gmail.com";

            ICustomerService customerService = new CustomerService();
            customerService.Insert(customer);
            customerService.Insert(customer1);
            
            List<Customer> allCustomers = customerService.GetAll();
            foreach(Customer Customer in allCustomers)
             
            {   
                Console.WriteLine(Customer.Id);
                Console.WriteLine(Customer.Email);
                Console.WriteLine(Customer.LastName);
                Console.WriteLine(Customer.FirstName);
                
            }
            Console.ReadLine();
            */

            /*
             * For Order

            Order Order1 = new Order();

            Order1.OrderId = 22;

            Order1.Status = "Delivered";

            Order1.Amount = 18900;

            Order1.Date = new DateTime(2023, 12, 10);

            Order Order2 = new Order();

            Order2.OrderId = 23;

            Order2.Status = "Rejected";

            Order2.Amount = 1307;

            Order2.Date = new DateTime(2024, 12, 10);

            IOrderService OrderService = new OrderService();

            OrderService.Insert(Order1);

            OrderService.Insert(Order2);

            List<Order> allOrders = OrderService.GetAll();

            foreach (Order Order in allOrders)

            {

                Console.WriteLine(Order.OrderId);

                Console.WriteLine(Order.Date);

                Console.WriteLine(Order.Amount);

                Console.WriteLine(Order.Status);

            }

            Console.ReadLine();
            */

            /*
             * Demo
             * 
            Product Product1 = new Product();

            Product1.OrderId = 22;

            Product1.Status = "Delivered";

            Product1.Amount = 18900;

            Product1.Date = new DateTime(2023, 12, 10);

            Product Product2 = new Product();

            Product2.OrderId = 23;

            Product2.Status = "Rejected";

            Product2.Amount = 1307;

            Product2.Date = new DateTime(2024, 12, 10);

            IOrderService ProductService = new ProductService();

            ProductService.Insert(Product1);

            ProductService.Insert(Product2);

            List<Order> allOrders = ProductService.GetAll();

            foreach (Order Product in allProducts)

            {

                Console.WriteLine(Product.OrderId);

                Console.WriteLine(Product.Date);

                Console.WriteLine(Product.Amount);

                Console.WriteLine(Product.Status);

            }

            Console.ReadLine();

            */



            Product Product1 = new Product();

            Product1.ProductId = 22;

            Product1.Title = "Mobile";

            Product1.Description = " OnePlus 8 Pro 128GB 8GB RAM";

            Product1.ImageUrl = ("C:\\Users\\chetan.more\\Documents\\SQL Server Management Studio\\Code Snippets\\SQL");

            Product1.UnitPrice = 60000;

            Product1.Quantity = 1;

            Product Product2 = new Product();

            Product2.ProductId = 25;

            Product2.Title = "Laptop";

            Product2.Description = "Lenovo Ideapad 8GB 512GB";

            Product2.ImageUrl = ("C:\\Users\\chetan.more\\Documents\\SQL Server Management Studio\\Code Snippets\\SQL");

            Product2.UnitPrice = 100000;

            Product2.Quantity = 90;


            IProductService productService = new ProductService();

            // IOrderService OrderService = new OrderService();

            productService.Insert(Product1);

            //productService.Insert(Product2);

            List<Product> products = productService.GetAll();

            foreach (Product product in products)

            {

                Console.WriteLine(product.ProductId);

                Console.WriteLine(product.Title);

                Console.WriteLine(product.Description);

                Console.WriteLine(product.UnitPrice);

                Console.WriteLine(product.Quantity);

                Console.WriteLine(product.ImageUrl);

            }

            productService.Update(Product2);

            Console.WriteLine("After :");

            foreach (Product product in products)

            {

                Console.WriteLine(product.ProductId);

                Console.WriteLine(product.Title);

                Console.WriteLine(product.Description);

                Console.WriteLine(product.UnitPrice);

                Console.WriteLine(product.Quantity);

                Console.WriteLine(product.ImageUrl);

            }

            Console.ReadLine();


        }
    }
}
