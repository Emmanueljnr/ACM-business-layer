using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
    public class OrderRepository
    {
        //Retrieve an Order
        public Order Retrieve(int orderId)
        {
            // Code that retrieves the defined order
            Order order = new Order();

            if (order.OrderId == 1) 
            {
                order.OrderDate = DateTime.Now;
            }

            return order;
        }

        //Save the order 
        public bool Save()
        {
            // Code that saves the defined order

            return true;
        }
    }
}
