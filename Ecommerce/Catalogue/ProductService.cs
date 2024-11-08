using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Catalogue
{
    public class ProductService : IProductService
    {
        private List<Product> products;

        public ProductService()

        {

            this.products = new List<Product>();

        }
        public bool Delete(int id)
        {
            Product product = this.Get(id);

            products.Remove(product);

            return true;
            //throw new NotImplementedException();
        }

        public Product Get(int id)
        {
            //foreach(Product product in products)

            //{

                //if (product.Id == id) return product;

            //}

            return new Product { Id = 1, Name = "Jaya", Description = "Flower", Price = 23, Quantity = 12, Url = "/Images/rose.jfif" };
            ;
            //throw new NotImplementedException();
        }

        public List<Product> GetAll()
        {
            List<Product> products = new List<Product>();
            products.Add(new Product { Id = 1, Name = "Jaya", Description = "Flower", Price = 23, Quantity = 12, Url = "/Images/rose.jfif" });
            products.Add(new Product { Id = 2, Name = "Jasmine", Description = "Flower Grey ", Price = 23554, Quantity = 32, Url = "/Images/rose.jfif" });
            products.Add(new Product { Id = 3, Name = "Rose", Description = "Flower Black", Price = 2323, Quantity = 22, Url = "/Images/rose.jfif" });

            // add descrpyion
            return this.products;
            //throw new NotImplementedException();
        }

        public bool Insert(Product product)
        {
            this.products.Add(product);

            return true;
            //throw new NotImplementedException();
        }

        public bool Update(Product product)
        {
            Product product1 = this.Get(product.Id);

            products.Remove(product);

            products.Add(product1);

            return true;
            //throw new NotImplementedException();
        }
    }
}
