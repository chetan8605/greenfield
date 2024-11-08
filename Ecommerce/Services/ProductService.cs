using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using POCOLib;
using Specification;
using BinaryDataRepositoryLib;

namespace Services
{
    public class ProductService : IProductService
    {
        public bool Seeding() { bool status =  false;
            List<Product> products = new List<Product>();
            products.Add(new Product { Id = 1, Name = "Jaya", Description = "Flower", Price = 23, Quantity = 12, Url = "/Images/rose.jfif" });
            products.Add(new Product { Id = 2, Name = "Jasmine", Description = "Flower Grey ", Price = 23554, Quantity = 32, Url = "/Images/rose.jfif" });
            products.Add(new Product { Id = 3, Name = "Rose", Description = "Flower Black", Price = 2323, Quantity = 22, Url = "/Images/rose.jfif" });
            IDataRepository repository = new BinaryRepository();
            status = repository.Serialize("products.dat",products);
            return status;
        }
        private List<Product> products;

        public ProductService()

        {

            this.products = new List<Product>();

        }
        public bool Delete(int id)
        {
            Product theProduct = Get(id);
            if(theProduct != null)
            {
                List<Product> allProducts = GetAll();
                allProducts.Remove(theProduct);
                IDataRepository repo = new BinaryRepository();
                repo.Serialize("products.dat",allProducts);
                //return false;
            }

            //products.Remove(product);

            return false;
            //return true;
            //throw new NotImplementedException();
        }

        public Product Get(int id)
   
        {
            Product foundProduct =  null;
            List<Product> products = GetAll();
            foreach(Product p in products)
            {
                if(p.Id == id)
                {
                    foundProduct = p;
                }
            }
            return foundProduct;

            //foreach(Product product in products)

            //{

            //if (product.Id == id) return product;

            //}

            //return new Product { Id = 1, Name = "Jaya", Description = "Flower", Price = 23, Quantity = 12, Url = "/Images/rose.jfif" };
            ;
            //throw new NotImplementedException();
        }

        public List<Product> GetAll()
        {
            List<Product> products = new List<Product>();
            //products.Add(new Product { Id = 1, Name = "Jaya", Description = "Flower", Price = 23, Quantity = 12, Url = "/Images/rose.jfif" });
            //products.Add(new Product { Id = 2, Name = "Jasmine", Description = "Flower Grey ", Price = 23554, Quantity = 32, Url = "/Images/rose.jfif" });
            //products.Add(new Product { Id = 3, Name = "Rose", Description = "Flower Black", Price = 2323, Quantity = 22, Url = "/Images/rose.jfif" });
            IDataRepository repository = new BinaryRepository();
            products = repository.Deserialize("products.dat");
            return products;
            // add descrpyion
            //return this.products;
            //throw new NotImplementedException();
        }

        public bool Insert(Product product)
        {
            List<Product> allProducts = GetAll();
            allProducts.Add(product);
            IDataRepository repository = new BinaryRepository();
            repository.Serialize("products.dat", allProducts);
            return true;
            //this.products.Add(product);

            //return true;
            //throw new NotImplementedException();
        }

        public bool Update(Product productToBeUpdated)
        {
            Product theProduct = this.Get(productToBeUpdated.Id);
            if (theProduct != null)
            {
                List<Product> allProducts = GetAll();
                allProducts.Remove(theProduct);
                IDataRepository repository = new BinaryRepository();
                repository.Serialize("products.dat", allProducts);
            }
            return true;
            //Product product1 = this.Get(product.Id);

            //products.Remove(product);

            //products.Add(product1);

            //return true;
            //throw new NotImplementedException();
        }
    }
}
