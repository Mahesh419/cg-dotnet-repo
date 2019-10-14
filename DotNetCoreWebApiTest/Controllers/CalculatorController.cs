using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DotNetCoreWebApiTest.Controllers
{
    [ApiController]
    public class CalculatorController : ControllerBase
    {
        private readonly ICalculator calculator;

        public CalculatorController(ICalculator calculator)
        {
            this.calculator = calculator;
        }

        [Route("api/calculator/add")]
        [HttpGet]
        public int Add(int x, int y)
        {
            return calculator.Add(x,y);
        }        
    }
}