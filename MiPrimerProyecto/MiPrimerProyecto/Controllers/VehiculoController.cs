using Microsoft.AspNetCore.Mvc;

namespace MiPrimerProyecto.Controllers
{
    [ApiController]
    [Route("api/v1/[controller]")]
    public class VehiculoController:ControllerBase
    {
        //TOKEN
        [HttpGet("{nombre}")]
        public IActionResult Get(string nombre)
        {
            string token = "dgfsdgdfgdfgd3425234gefgdf";
            return Ok(new
            {
                token = token,
                mensaje = ""

            });
            
        }
    }
}
