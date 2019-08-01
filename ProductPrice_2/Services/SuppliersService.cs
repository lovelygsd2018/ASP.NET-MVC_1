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
    public class SuppliersService : ISuppliersService
    {
        private readonly ISuppliersRepository _repo;
        public SuppliersService(ISuppliersRepository repo)
        {
            _repo = repo;
        }
        public async Task<IActionResult> GetAllSuppliersAsync()
        {
            try{
                IEnumerable<Supplier> suppList = await _repo.GetAllSuppliersAsync();
                if(suppList != null){
                    //return new OkObjectResult(suppList.Select(s => new SupplierViewModel
                    //{ Id = s.SupplierId, Name = s.Name })
                    //);
                    var list = suppList.Select(s => new SupplierViewModel
                    {
                        Id = s.SupplierId,
                        Name = s.Name
                    });
                    return new OkObjectResult(list);
                }else{
                    return new  NotFoundResult();
                }
            }catch{
                return  new ConflictResult();
            }
        }

        public async Task<IActionResult> GetSupplierbyIdAsync(int supplierId){
            try{
                var supp = await _repo.GetSupplierbyIdAsync(supplierId);
                if (supp == null){
                    return new NotFoundResult();
                }else{
                    return new OkObjectResult(supp);
                }
            }catch{
                return new ConflictResult();
            }
        }
    }
}
