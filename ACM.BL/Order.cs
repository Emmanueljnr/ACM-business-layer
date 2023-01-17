using System;

namespace ACM.BL
{
  public class Order
  {
    public Order() { }
    public Order(int orderId)
    {
      OrderId = orderId;
    }

        //public static DateTimeOffset? OrderDate 
        public DateTimeOffset? OrderDate 
        {
            get 
            {
                OrderDate = DateTimeOffset.Now;
                return OrderDate;
            }
            set 
            {
            
            }
        }
    public int OrderId { get; private set; }

    //Validate the order data
    public bool Validate()
    {
      bool isValid = true;

      if (OrderDate == null) isValid = false;

      return isValid;
    }
  }
}
