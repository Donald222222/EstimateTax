using EstimateTax.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace EstimateTax.Controllers
{
    public class TaxController : Controller
    {
        private readonly ITaxInfo _taxinfo;


        public TaxController(ITaxInfo taxinfo)
        {
            _taxinfo = taxinfo;
        }

        [Route("")]


        public IActionResult Create()
        {


            return View();
        }
        [HttpGet]
        public double Index(double income, string postalCode)
        {
            if (string.IsNullOrWhiteSpace(postalCode) || Double.IsNaN(income)) throw new InvalidDataException("No postal provided.");


          var Tax = _taxinfo.TaxCalculation(income, postalCode);

            ViewBag.Calculate= Tax;


            return Tax;
        }
    }
}
