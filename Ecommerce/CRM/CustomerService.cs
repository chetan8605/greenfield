using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRM
{
    public class CustomerService : ICustomerService
    {
        private List<Customer> _customerList;

        public CustomerService() { 
        
            this._customerList = new List<Customer>();
        }
        public bool Delete(int id)
        {
            Customer theCustomer = this.Get(id);
            return this._customerList.Remove(theCustomer);

            //throw new NotImplementedException();
        }

        public Customer Get(int id)
        {
            foreach(Customer customer in _customerList) {
            if(customer.Id == id) return customer;    
            }
            return null;
            //throw new NotImplementedException();
        }

        public List<Customer> GetAll()
        {
            List<Customer> customers = new List<Customer>();
            customers.Add(new Customer { Id = 1, FirstName = "Rutuja", LastName = "Patil", Email = "rsyadav@gmail.com", ContactNo = "8778964521" });
            customers.Add(new Customer { Id = 1, FirstName = "Sam", LastName = "Deshmukh", Email = "patil@gmail.com", ContactNo = "1234567890" });
            customers.Add(new Customer { Id = 1, FirstName = "Gauri", LastName = "Takilkar", Email = "sam@gmail.com", ContactNo = "9876543210" });
            customers.Add(new Customer { Id = 1, FirstName = "Jasmin", LastName = "Wedding Flower", Email = "tyafey@gmail.com", ContactNo = "4512789632" });
            customers.Add(new Customer { Id = 1, FirstName = "Lotus", LastName = "Wedding Flower", Email = "ftqyet@gmai.com", ContactNo = "7418529632" });

            return this.Customer;
            //throw new NotImplementedException();
        }

        public bool Insert(Customer customer)
        {
            this._customerList.Add(customer);
            return true;
            //throw new NotImplementedException();
        }

        public bool Update(Customer customer)
        {
            Customer theCustomer = this.Get(customer.Id);
            this._customerList.Remove(customer);
            this._customerList.Add(customer);
            return true;

            //throw new NotImplementedException();
        }
    }
}
