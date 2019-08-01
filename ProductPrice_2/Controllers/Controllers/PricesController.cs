using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProductPrice_2.Interfaces;

namespace ProductPrice_2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PricesController : ControllerBase
    {
        private readonly IPricesService _service;
        public PricesController(IPricesService service)
        {
            _service = service;
        }
        [HttpGet]
        public async Task<IActionResult> GetAllPrices()
        {
            return await _service.GetAllPricesFullAsync();
        }
        [HttpGet("{id:int}")]
        public async Task<IActionResult> GetPriceByIdAync(int id)
        {
            return await _service.GetPricetbyIdAsync(id);
        }
    }
}
