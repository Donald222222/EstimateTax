using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EstimateTax
{
    public interface ITaxInfo
    {
      
        double TaxCalculation( double income, string PostalaCode);
    }
}
