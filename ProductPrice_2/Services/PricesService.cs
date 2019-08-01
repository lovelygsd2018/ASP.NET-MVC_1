using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ProductPrice_2.Interfaces;
using ProductPrice_2.Models;
using ProductPrice_2.Repositories;
using ProductPrice_2.ViewModels;
using Microsoft.AspNetCore.Mvc; //IActionResult
using Microsoft.EntityFrameworkCore;

namespace ProductPrice_2.Services
{
    public class PricesService : IPricesService
    {
        private readonly IPricesRepository _pricesRepository;
        private readonly IProductsRepository _productsRepository;
        private readonly ISuppliersRepository _suppliersRepository;
        public PricesService(IPricesRepository PriceRepo,
                            IProductsRepository ProductRepo,
                            ISuppliersRepository SuppliersRepo)
        {
            _pricesRepository = PriceRepo;
            _productsRepository = ProductRepo;
            _suppliersRepository = SuppliersRepo;
        } 

        public async Task<IActionResult> GetAllPricesAsync()
        {
            var prices = await _pricesRepository.GetAllPricessAsync();
      
            return new  OkObjectResult(prices);
        }
        public async    Task<IActionResult> GetAllPricesFullAsync()
        {
            var prices = await _pricesRepository.GetAllPricessAsync();
            var prods = await _productsRepository.GetAllProductsAsync();
            var supps = await _suppliersRepository.GetAllSuppliersAsync();
            var list = from pri in prices
                        join
          pro in prods on pri.ProductId equals pro.ProductId
                        join su in supps on pri.SupplierId equals su.SupplierId
                        select new PriceFullViewModel
                        {
                            Product = pro.Name,
                            Price = pri.Cost,
                            Supplier = su.Name
                        };
            return new OkObjectResult(list);
        }
        public async Task<IActionResult> GetPricetbyIdAsync(int priceId)
        {
            try{
                var price = await _pricesRepository.GetPricebyIdAsync(priceId);
                if (price != null){
                    return new OkObjectResult(price);
                }else{
                    return new NotFoundResult();
                }
            }catch{
                return new ConflictResult();
            }
        }
    }
}
