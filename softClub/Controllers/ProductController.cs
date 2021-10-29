using System;
using Microsoft.AspNetCore.Mvc;
using Services.Services;

namespace softClub.Controllers
{
    public class ProductController : Controller
    {
        private readonly ProductService _productService; //field
        public ProductController()
        {
            _productService = new ProductService();
        }


        public IActionResult Index()
        {
            var list = _productService.GetProductList();
            return View(list);
        }
    }
}
