using Microsoft.AspNetCore.Mvc;
using Rookie.Ecom.Business.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Rookie.Ecom.MVC.Controllers
{
    public class HomeController : Controller
    {
        private readonly IProductService _productService;
        public HomeController(IProductService productService)
        {
            _productService = productService;
        }
        public async Task<IActionResult> Index()
        {
            var listProduct = await _productService.GetAllAsync();
            ViewBag.TopSeller = listProduct.TakeLast(3);
            return View(listProduct);
        }
        public async Task<IActionResult> ProductDetail(Guid id)
        {
            var product = await _productService.GetByIdAsync(id);
            ViewBag.RealatedProduct = (await _productService.GetAllAsync()).Take(6);
            return View(product);
        }
        public async Task<IActionResult> ProductList()
        {
            var listProduct = await _productService.GetAllAsync();
            return View(listProduct);
        }
        public async Task<IActionResult> ProductByCategory(Guid id)
        {
            var listProduct = await _productService.GetAllAsync();
            var productByCategory = (from product in listProduct
                                     where product.CategoryId == id
                                     select product).ToList();
            return View(listProduct);
        }
    }
}
