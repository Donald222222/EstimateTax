using EstimateTax.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EstimateTax.DataContext
{
    public class DataContexts :DbContext
    {
        public DataContexts(DbContextOptions options) : base(options)
        {
        }
        public DbSet<TaxInfo> TaxInfos { get; set; }
        public DbSet<TaxBakets> Progressives { get; set; }
        public DbSet<FlatRateTax> FlatRates { get; set; }
        public DbSet<FlatValueTax> FlatValues { get; set; }


    }
}
