using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
    internal class OrderItemRepository
    {
        //Retrieve Order Item
        public OrderItem Retrieve(int orderItemId)
        {
            OrderItem item = new OrderItem(); //In order to retrieve an OrderItem, i need to create an object of that OrderItem 1st

            // Code that retrieves the defined order item
            if (orderItemId == 1) 
            {
                item.ProductId = 1;
                item.PurchasePrice = 10.99m;
                item.Quantity = 5;
            }

            return new OrderItem();
        }

        //Save the order item
        public bool Save()
        {
            // Code that saves the defined order item

            return true;
        }
    }
}
