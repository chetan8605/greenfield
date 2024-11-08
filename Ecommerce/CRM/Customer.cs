using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRM
{
    // POCO : Plain Old CLR Object
    public class Customer
    {
        //private string firstName;
        //private string lastName;
        //private string email;
        //private string contactNumber;
        //private int id;

        /////
        public int Id { get; set; } // Auto property
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }


    }
}
