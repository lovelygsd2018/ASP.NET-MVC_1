using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ProductPrice_2.Models;

namespace ProductPrice_2.Interfaces
{
    public interface ISuppliersRepository
    {
        Task<IEnumerable<Supplier>> GetAllSuppliersAsync();
        Task<Supplier> GetSupplierbyIdAsync(int supplierId);
    }
}
