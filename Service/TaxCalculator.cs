using EstimateTax.DataContext;
using EstimateTax.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using EstimateTax.Repository;
using EstimateTax.Extentions;

namespace EstimateTax.Service
{
    public class TaxCalculator : ITaxInfo
    {
        private readonly IRepo _data;
       

        public TaxCalculator(IRepo data)
        {
        
            _data = data;
        }

        public double TaxCalculation(double income, string PostalCode)
        {


            var taxtype = _data.GetTaxTypeAsyc(PostalCode).ToString();
     
      

         

            double tax = 0;
            if (taxtype == Type_of_tax.ProgressiveTax)
            {

                tax = _data.PrograssiveTax(income);

            }


            else if (taxtype == Type_of_tax.FlatValueTax)
            {
                tax = (double)_data.GetFix_FlatValueTax(income);

                tax = _data.GetVarying_FlatValueTax(income);

            }

            else if (taxtype == Type_of_tax.FlatRateTax)
            {
                tax = _data.GetFlateRate(income);

            
            }
            return tax;
        }

             
    }
                        
}
      



    


