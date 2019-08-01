using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

using ProductPrice_2.Interfaces;
//using Microsoft.AspNetCore;

namespace ProductPrice_2.Controllers
{
    //[Route("api/[controller]")]
    [Route("api/SuppList")]
    [ApiController]
    public class SuppliersController : ControllerBase
    {
        private readonly ISuppliersService _service;
        public SuppliersController(ISuppliersService service)
        {
            _service = service;
        }

        [HttpGet]
        public async    Task<IActionResult> GetAllSuppliers()
        {
            return await _service.GetAllSuppliersAsync();
        }
        [HttpGet("{id:int}")]
        public async Task<IActionResult>    GetSupplierById(int id)
        {
            return await _service.GetSupplierbyIdAsync(id);
        }
    }
}