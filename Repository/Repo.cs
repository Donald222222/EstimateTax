using EstimateTax.DataContext;
using EstimateTax.Models;
using EstimateTax.NullChecks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EstimateTax.Repository
{
    public class Repo : IRepo
    {
        private readonly DataContexts _data;

        public Repo( DataContexts data)
        {
            _data = data;
        }


        public double GetFix_FlatValueTax(double income)
        {
            var tax = _data.FlatValues.Where(x => x.Fix_Flatate_per_Income < income)
            .Select(x => x.FlatValue_Per_Income).FirstOrDefault();

            return tax;
        }
        public double GetVarying_FlatValueTax(double income)
        {
            var  Ratetax = _data.FlatValues.Where(x => x.Fix_Flatate_per_Income > income)
                
            .Select(x => x.rate/100).Single();

            var CalculateTax2 = Ratetax * income ;
            return CalculateTax2;
     
        }

        public double GetFlateRate( double income)
        {
            double taxate = _data.FlatRates.Select(x => x.FlatRate_Per_Income).Single();
            double Caculated = (taxate * income)/100;
            return Caculated;
            
        }

        public List<TaxBakets> GetTaxBrakets()
        {
            return _data.Progressives.ToList();
        }
      

        public string GetTaxTypeAsyc( string PostalCode)
        {
          
             var tax = _data.TaxInfos.Where(x => x.PostalCode == PostalCode).Select(x => x.TaxTypes).FirstOrDefault();
            if (tax ==null)
            {
                return new InvalidPostalCode().GetTaxTypeAsyc(PostalCode);
            }
            else
            {
                return tax;
            }         
                   
           
        }

        public double PrograssiveTax(double income)
        {

            var taxBrakets = this.GetTaxBrakets();


            double tax = 0;
            foreach (var item in taxBrakets)
            {
                double TaxCalculato = Math.Min(item.To, Math.Max(income - item.From, 0));
                tax += TaxCalculato * item.Rate / 100;

            }
            return tax;
        }
    }
}
