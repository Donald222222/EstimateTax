using EstimateTax.Models;
using EstimateTax.Repository;
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
        private readonly IRepo _data;

        public TaxController(ITaxInfo taxinfo, IRepo data)
        {
            _taxinfo = taxinfo;
            _data = data;
        }

        [Route("")]


        public IActionResult Create()
        {


            return View();
        }
        [HttpGet]
        public IActionResult Index(double income, string postalCode)
        {
            if (string.IsNullOrWhiteSpace(postalCode) || Double.IsNaN(income)) throw new InvalidDataException("No postal provided.");


          var Tax = _taxinfo.TaxCalculation(income, postalCode);
            var Taxtype = _data.GetTaxTypeAsyc(postalCode);


            ViewBag.Calculate= Tax;
            ViewBag.TaxType = Taxtype;

            return View(Tax);
        }
    }
}
