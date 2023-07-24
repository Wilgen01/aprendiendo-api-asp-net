using aprendiendo_api_asp_net.Models;
using Microsoft.AspNetCore.Mvc;

namespace aprendiendo_api_asp_net.Controllers
{
    [ApiController]
    [Route("cliente")]
    public class ClienteController : ControllerBase
    {
        public ClienteController() { }

        [HttpGet]
        [Route("")]
        public List<Persona> listarCliente()
        {
            return new List<Persona>{
                new Persona
                {
                    nombres = "Wilgen",
                    apellidos = "García",
                    edad = 21

                }
            };
        }

        [HttpPost]
        [Route("agregar")]
        public IActionResult agregarCliente(Persona persona)
        {
            return Ok(persona);
        }


    }
}
