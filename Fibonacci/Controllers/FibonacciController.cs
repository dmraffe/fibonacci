using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Fibonacci.Logic;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Fibonacci.Controllers
{
      
    public class FibonacciController : Controller
    {
        private readonly IFibonaccinterface _fibonaccionservices;

        // GET: /<controller>/

        public FibonacciController(IFibonaccinterface fibonacciservices)
        {
            _fibonaccionservices = fibonacciservices;
        }

        [Route("Fibonacci/{valor}")]
        public IActionResult Index(string  valor)
        {
            int value = 0;

            if (string.IsNullOrEmpty(valor))
                return BadRequest();

            if (!int.TryParse(valor, out value))
                return BadRequest();
             
            return Ok(_fibonaccionservices.GetFibonacci(value));
        }
    }
}

