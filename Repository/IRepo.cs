using EstimateTax.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EstimateTax.Repository
{
    public interface IRepo
    {
         String GetTaxTypeAsyc( string PostalCode);
        List<TaxBakets> GetTaxBrakets();
        double GetFix_FlatValueTax( double income);
        double GetVarying_FlatValueTax(double income);
        double GetFlateRate(double income);


    }
}
