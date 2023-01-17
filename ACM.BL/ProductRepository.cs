using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
    internal class ProductRepository
    {
        //Retrieve a product based on its Id
        public Product Retrieve(int productId)
        {   
            // Code that retrieves the defined product
            Product product = new Product();
            if (productId == 1)
            {
                product.CurrentPrice = 10.99m;
                product.ProductDescription = "Cookworks Plastic Kettle - Black";
                product.ProductName = "Kettle";
            }
            return product;
        }


        public decimal? CurrentPrice { get; set; }
        public string ProductDescription { get; set; }
        public int ProductId { get; private set; }
        public string ProductName { get; set; }


        //Save a product
        public bool Save()
        {
            // Code that saves the defined product

            return true;
        }
    }
}
