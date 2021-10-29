using System.Security.AccessControl;
using System;

namespace Domains.Models
{
    public class Product
    {

        public int Id { get; set; }
        public string ProductName { get; set; }
        public decimal Price { get; set; }
        public int ProductCount { get; set; }


        public Product()
        {

        }
        public Product(string productname, decimal price, int productCount)
        {
            ProductName = productname;
            Price = price;
            ProductCount = productCount;
        }


    }
}
