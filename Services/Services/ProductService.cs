using System;
using System.Collections.Generic;
using Domains.Models;

namespace Services.Services
{
    public class ProductService
    {
        public ProductService()
        {

        }

        public void Insert()
        {

        }

        public List<Product> GetProductList()
        {
            var list = new List<Product>();
            for (int i = 1; i <= 10; i++)
            {
                var product = new Product()
                {
                    Id = new Random().Next(1, 100),
                    Price = new Random().Next(1, 1000),
                    ProductName = "Product" + new Random().Next(1, 100),
                    ProductCount = new Random().Next(1, 1000)
                };

                list.Add(product);

            }
            return list;
        }
    }
}
