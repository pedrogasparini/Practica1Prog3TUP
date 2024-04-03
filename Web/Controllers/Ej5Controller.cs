using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Ej5Controller : Controller
    {
        [HttpGet()]
        public string Get([FromQuery] string day)
        {
            day = day.Trim();

            day = day.ToLower();

            if (day.Equals("sábado") || day.Equals("sabado") || day.Equals("domingo"))
            {
                return ("Es fin de semana");
            }

            else if (day.Equals("lunes") || day.Equals("martes") || day.Equals("miércoles") || day.Equals("miercoles") ||
                     day.Equals("jueves") || day.Equals("viernes"))
            {
                return ("No es fin de semana.");
            }
            else
            {
                return ("El dia ingresado no es valido.");
            }
        }
    }
}
