using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ProductPrice_2.Interfaces;
using ProductPrice_2.Contexts;
using ProductPrice_2.Models;
using Microsoft.EntityFrameworkCore;    //.ToListAsync();


namespace ProductPrice_2.Repositories
{
    public class ProductsRepository : IProductsRepository
    {
        private readonly    DefaultContext _context;
        public ProductsRepository(DefaultContext    context)
        {
            _context = context;
        }
        public async Task<IEnumerable<Product>> GetAllProductsAsync()
        {
            return await _context.Products.ToListAsync();
        }
        public async Task<Product> GetProductbyIdAsync(int productId)
        {
            return await _context.Products.Where(p => p.ProductId == productId).FirstOrDefaultAsync();
        }

    }
}
