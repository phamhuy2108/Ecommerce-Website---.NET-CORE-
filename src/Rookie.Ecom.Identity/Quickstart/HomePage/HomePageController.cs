using Microsoft.AspNetCore.Mvc;
using Rookie.Ecom.Business.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Rookie.Ecom.Identity.Quickstart.HomePage
{
    public class HomePageController : Controller
    {
        private readonly IProductService _productService;
        public HomePageController(IProductService productService)
        {
            _productService = productService;
        }
        public async Task<IActionResult> Index()
        {
            var listProduct = await _productService.GetAllAsync();
            return View(listProduct);
        }
    }
}
