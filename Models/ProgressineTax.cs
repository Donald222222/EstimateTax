﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EstimateTax.Models
{
    public class TaxBakets
    {

        public int Id { get; set; }
        public double Rate { get; set; }
        public double From { get; set; }
        public double To{ get; set; }
    }
}
