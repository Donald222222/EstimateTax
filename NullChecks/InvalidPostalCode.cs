using EstimateTax.Models;
using EstimateTax.Repository;
using System;
using System.Collections.Generic;

namespace EstimateTax.NullChecks
{
    public class InvalidPostalCode : IRepo
    {
        public double GetFix_FlatValueTax(double income)
        {
            throw new System.NotImplementedException();
        }

        public double GetFlateRate(double income)
        {
            throw new System.NotImplementedException();
        }

        public List<TaxBakets> GetTaxBrakets()
        {
            throw new System.NotImplementedException();
        }

        public string GetTaxTypeAsyc(string PostalCode)
        {
            return "Invalid PostalCode";
        }

        public double GetVarying_FlatValueTax(double income)
        {
            throw new System.NotImplementedException();
        }

        public double PrograssiveTax(double income)
        {
            throw new NotImplementedException();
        }
    }
}
