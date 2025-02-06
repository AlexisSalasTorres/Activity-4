using Microsoft.AspNetCore.Mvc;

namespace Activity_4.Controllers
{
    [Route("AdvancedOperations")]
    public class AdvanceOperationsController : Controller
    {
        [HttpGet("Square/{num}")]
        public IActionResult Square(double num)
        {
            double result = num * num;
            return Content($"Square of {num}: {result}");
        }

        [HttpGet("SquareRoot/{num}")]
        public IActionResult SquareRoot(double num)
        {
            if (num < 0)
                return Content("Error: Cannot calculate square root of a negative number.");

            double result = Math.Sqrt(num);
            return Content($"Square root of {num}: {result}");
        }

        [HttpGet("Power/{baseNum}/{exponent}")]
        public IActionResult Power(double baseNum, double exponent)
        {
            double result = Math.Pow(baseNum, exponent);
            return Content($"{baseNum} raised to the power of {exponent}: {result}");
            
        }
    }
}
