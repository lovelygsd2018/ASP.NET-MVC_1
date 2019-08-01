using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ProductPrice_2.Contexts;
using ProductPrice_2.Models;
using Microsoft.EntityFrameworkCore;    //.ToListAsync()
using ProductPrice_2.Interfaces;

namespace ProductPrice_2.Repositories
{
    public class PricesRepository : IPricesRepository
    {
        private readonly DefaultContext _context;
        public PricesRepository(DefaultContext context) 
        {
            _context = context;
        }
        public async    Task<IEnumerable<Price>> GetAllPricessAsync()
        {
            return await _context.Prices.ToListAsync();
        }
        public async Task<Price> GetPricebyIdAsync(int priceId)
        {
            Price price = await _context.Prices.Where(p => p.PriceId == priceId).FirstOrDefaultAsync();
            return price;

        }
    }
}
