using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc; //IActionResult

namespace ProductPrice_2.Interfaces
{
    public interface IProductService
    {
        Task<IActionResult> GetAllProductsAsync();
        Task<IActionResult> GetProductbyIdAsync(int productId);
    }
}
