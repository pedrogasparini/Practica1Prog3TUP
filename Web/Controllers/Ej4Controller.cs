using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Ej4Controller : Controller
    {
        [HttpGet()]
        public string Get([FromQuery] int number1, [FromQuery] int number2)
        {
            if (number1 > number2) {
                return ($"El numero mas grande es {number1}");
                
            }
            else if (number1 < number2)
            {
                return ($"El numero mas grande es {number2}");

            }
            else
            {
                return ("Ambos son iguales");
            }
        }
    }
}
