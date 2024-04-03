using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Ej6Controller : Controller
    {
        [HttpGet()]
        public string Get()
        {
            int[] numeros = new int[100];

            for (int i = 0; i < 100; i++) {
                return ($"Numero:{i}");
            }
            
        }
    }
}
