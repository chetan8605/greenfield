﻿using Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Services;
using POCOLib;

namespace SerializationTestApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ProductService svc = new ProductService();
            svc.Seeding();
            List<Product> allProducts = svc.GetAll();
            foreach (Product product in allProducts)
            {
                Console.WriteLine(product.Name + " " + product.Price);
            }
            Console.ReadLine();

        }
    }
}