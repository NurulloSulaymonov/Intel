using System;
using Domains.Entities;
using Domains.Models;
using Microsoft.AspNetCore.Mvc;
using Services.Services;

namespace softClub.Controllers
{
    public class ProductController : Controller
    {
        private readonly ProductService _productService; //field
        public ProductController(ProductService productService)
        {
            _productService = productService;
        }



        [HttpGet]
        public IActionResult Insert()
        {
            return View(new Product());
        }

        [HttpPost]
        public IActionResult Insert(Product product)
        {
            _productService.Insert(product);
            return View();
        }

        
        [HttpGet]
        public IActionResult Update([FromQuery] int id)
        {
            var product = _productService.GetProductById(id);
            return View(product);
        }

        [HttpPost]
        public IActionResult Update(Product product)
        {
            _productService.Update(product);
            return View();
        }
        
        public IActionResult Index()
        {
            var list = _productService.GetProductList();
            return View(list);
        }
    }
}
