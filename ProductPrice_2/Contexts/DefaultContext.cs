using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;    //DbContext
using ProductPrice_2.Models;

namespace ProductPrice_2.Contexts
{
    public class DefaultContext : DbContext
    {
        public virtual DbSet<Product>  Products     { get; set;}
        public virtual DbSet<Price>     Prices      { get; set;}
        public virtual DbSet<Supplier> Suppliers    { get; set;}

        public DefaultContext(DbContextOptions<DefaultContext> options) : base(options)
        {
        }
    }
}

