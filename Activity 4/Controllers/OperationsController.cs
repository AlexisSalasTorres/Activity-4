using Microsoft.AspNetCore.Mvc;

namespace Activity_4.Controllers
{
    [Route("Operations")]
    public class OperationsController : Controller
    {
        [HttpGet("{operation}/{num1}/{num2}")]
        public IActionResult Calculate(string operation, double num1, double num2)
        {
            double result;

            switch (operation.ToLower())
            {
                case "add":
                    result = num1 + num2;
                    break;
                case "subtract":
                    result = num1 - num2;
                    break;
                case "multiply":
                    result = num1 * num2;
                    break;
                case "divide":
                    if (num2 == 0)
                        return Content("Error: Division by zero is not allowed.");
                    result = num1 / num2;
                    break;
                default:
                    return Content("Error: Invalid operation. Use Add, Subtract, Multiply, or Divide.");
            }

            return Content($"Result of {operation}: {result}");
        }
    } 
}
