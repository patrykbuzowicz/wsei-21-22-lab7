using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Wsei.Lab7.Database;
using Wsei.Lab7.Entities;
using Wsei.Lab7.Models;
using Wsei.Lab7.Services;

namespace Wsei.Lab7.Controllers
{
    [Authorize]
    public class ProductsController : Controller
    {
        private readonly IProductService _productService;

        public ProductsController(IProductService productService)
        {
            _productService = productService;
        }

        public IActionResult Index()
        {
            return View();
        }

        public async Task<IActionResult> Add(ProductModel product)
        {
            await _productService.Add(product);

            var viewModel = new ProductStatsViewModel
            {
                NameLength = product.Name.Length,
                DescriptionLength = product.Description.Length
            };
            return View(viewModel);
        }

        [HttpGet]
        public async Task<IActionResult> List(string name)
        {
            var products = await _productService.GetAll(name);
            return View(products);
        }
    }
}
