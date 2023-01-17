using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
    public class CustomerRepository
    {
        public Customer Retrieve(int customerId) 
        {
            Customer customer = new Customer(customerId);

            //Code to retrieve Customers
            if(customerId == 1) 
            {
                customer.FirstName = "Emmanuel";
                customer.LastName = "Rufasha";
                customer.EmailAddress = "123@gmail.com";
            }

            return customer;
        }


        public bool Save(Customer customer) 
        { 
            //code to save items
            return true;
        }
    }
}
