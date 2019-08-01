using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProductPrice_2.Interfaces;
using Microsoft.AspNetCore;
namespace ProductPrice_2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly IProductService _productsService;
        public ProductsController(IProductService productsService)
        {
            _productsService = productsService;
        }
   
        [HttpGet]
        public async    Task<IActionResult> GetAllProductsAsync()
        {
            return await _productsService.GetAllProductsAsync();
        }
        [HttpGet("{id:int}")]
        public async    Task<IActionResult> GetProductbyIdAsync(int id)
        {
            return await _productsService.GetProductbyIdAsync(id);
        }
    }
}
