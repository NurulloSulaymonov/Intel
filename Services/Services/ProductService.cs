using System;
using System.Collections.Generic;
using System.Linq;
using Domains.Entities;
using Domains.Models;
using Persistence;

namespace Services.Services
{
    public class ProductService
    {
        private readonly SoftClubContext _context;

        public ProductService(SoftClubContext context)
        {
            _context = context;
        }

        public void Insert(Product product)
        {
            // inserted

            _context.Products.Add(product);
            _context.SaveChanges();
        }


        public void Update(Product product)
        {
            //product id should not be 0 
            // inserted
        }


        public GenericResponse<Product> GetProductById(int id)
        {
            var response = new Product()
            {
                Id = 1,
                Price = 23.2m,
                ProductCount = 2,
                ProductName = "test"
            };
            return new GenericResponse<Product>(response);

        }

        public List<Product> GetProductList()
        {

            return _context.Products.ToList();
           
        }
    }
}