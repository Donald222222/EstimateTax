using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EstimateTax.Models
{
    public class TaxInfo
    {
      [Key]
        public int TaxId { get; set; }


        [DataType(DataType.PostalCode)]
        [Required(ErrorMessage = "postal is required")]
        public string PostalCode { get; set; }
        public string TaxTypes { get; set; }
        [Required]
        [Range(0, double.MaxValue, ErrorMessage = "Number must be positive. ")]
        public double income { get; set; }
    }
}
