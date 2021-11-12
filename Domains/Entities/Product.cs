using System.Security.AccessControl;
using System;
using System.ComponentModel.DataAnnotations;

namespace Domains.Entities
{
    public class Product
    {

        [Key] // primary key
        public int Id { get; set; }
        [MaxLength(30),Required] // character (30) // not null
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
