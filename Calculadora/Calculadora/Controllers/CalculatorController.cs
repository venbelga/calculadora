using Microsoft.AspNetCore.Mvc;

namespace Calculadora.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CalculatorController : ControllerBase
    {

        private readonly ILogger<CalculatorController> _logger;



        public CalculatorController(ILogger<CalculatorController> logger)
        {
            _logger = logger;
        }

        [HttpGet("sum/{firstNumber}/{secondNumber}")]
        public IActionResult Sum(double firstNumber, double secondNumber)
        {
            return Ok(firstNumber + secondNumber);
        }

        [HttpGet("division/{firstNumber}/{secondNumber}")]
        public IActionResult Division(double firstNumber, double secondNumber)
        {
            return Ok(firstNumber / secondNumber);
        }

        [HttpGet("subtraction/{firstNumber}/{secondNumber}")]
        public IActionResult Subtraction(double firstNumber, double secondNumber)
        {
            return Ok(firstNumber - secondNumber);
        }

        [HttpGet("multiplication/{firstNumber}/{secondNumber}")]
        public IActionResult Multiplication(double firstNumber, double secondNumber)
        {
            return Ok(firstNumber * secondNumber);
        }

        [HttpGet("mean/{firstNumber}/{secondNumber}")]
        public IActionResult Mean(double firstNumber, double secondNumber)
        {
            return Ok((firstNumber + secondNumber) / 2);
        }

        [HttpGet("square-root/{firstNumber}")]
        public IActionResult SquareRoot(double firstNumber)
        {
            return Ok(Math.Sqrt(firstNumber));
        }
    }
}
