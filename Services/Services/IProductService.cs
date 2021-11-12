using System;
using System.Collections.Generic;
using Domains.Entities;
using Domains.Models;

namespace Services.Services
{
    public interface IProductService
    {
        List<Product> GetProductList();
        Product GetProductById(int id);
        void Insert(Product product);
        void Update(Product product);
    }
}
