using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProductPrice_2.Models
{
    public class Price
    {
        public int PriceId { get; set; }
        public int ProductId { get; set; }
        public decimal Cost { get; set; }
        public int SupplierId { get; set; }
    }
}
