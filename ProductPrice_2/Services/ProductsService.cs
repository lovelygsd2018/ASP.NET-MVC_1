using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ProductPrice_2.Interfaces;
using ProductPrice_2.Models;
using ProductPrice_2.Repositories;
using ProductPrice_2.ViewModels;
using Microsoft.AspNetCore.Mvc; //IActionResult

namespace ProductPrice_2.Services
{
    public class ProductsService : IProductService
    {
        private readonly IProductsRepository _productsRepository;

        public ProductsService(IProductsRepository productsRepository)
        {
            _productsRepository = productsRepository;
        }

        public async   Task<IActionResult> GetAllProductsAsync()
        {
            try{
                IEnumerable<Product> products = await _productsRepository.GetAllProductsAsync();
                if(products != null){
                    return new OkObjectResult(products.Select(p => new ProductViewModel{
                        Id = p.ProductId, Name = p.Name })
                    );
                }else{
                    return new NotFoundResult();
                }
            }catch {
                return new ConflictResult();
            }
        }

        public async   Task<IActionResult> GetProductbyIdAsync(int productId)
        {
            try{
                Product prod = await _productsRepository.GetProductbyIdAsync(productId);
                if(prod != null){
                    return new OkObjectResult(new ProductViewModel()
                    {
                        Id = prod.ProductId,
                        Name = prod.Name
                    });;
                }else{
                    return new NotFoundResult();
                }
            }catch{
                return new ConflictResult();
            }           
        }
    }
}
