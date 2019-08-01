using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ProductPrice_2.Interfaces;
using ProductPrice_2.Models;
using ProductPrice_2.Contexts;
using Microsoft.EntityFrameworkCore;    //.ToListAsync()

namespace ProductPrice_2.Repositories
{
    public class SuppliersRepository : ISuppliersRepository
    {
        private readonly DefaultContext _context;
        public SuppliersRepository(DefaultContext context)
        {
            _context = context;
        }

        public async    Task<IEnumerable<Supplier>> GetAllSuppliersAsync()
        {
            return await _context.Suppliers.ToListAsync();
        }
        public async Task<Supplier> GetSupplierbyIdAsync(int supplierId)
        {
            return await _context.Suppliers.Where(sup => sup.SupplierId == supplierId).FirstOrDefaultAsync();
        }
    }
}
