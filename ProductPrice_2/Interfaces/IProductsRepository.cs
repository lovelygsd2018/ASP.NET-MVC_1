using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ProductPrice_2.Models;

namespace ProductPrice_2.Interfaces
{
    public interface IProductsRepository
    {
        Task<IEnumerable<Product>> GetAllProductsAsync();
        Task<Product> GetProductbyIdAsync(int productId);
        //Task<IEnumerable<Product>> FindProductsAsync(string sku);
        //Task<Product> DeleteProductAsync(int productId);
    }
}

