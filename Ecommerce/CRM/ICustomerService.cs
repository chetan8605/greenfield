﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRM
{   
    //Prototype,Contrct , Specification
    public interface ICustomerService
    {
        List<Customer> GetAll();// Abstract Methods with No implementation 
        Customer Get(int id);
        bool Insert(Customer customer);
        bool Update(Customer customer);
        bool Delete(int id);
        //Customer Update(Customer customer)
    }
}
