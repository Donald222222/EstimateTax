using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EstimateTax.Models
{
    public class FlatValueTax
    {
        public int Id { get; set; }
        public double FlatValue_Per_Income { get; set; }
        public double Fix_Flatate_per_Income { get; set; }
        public double rate { get; set; }
    }
}