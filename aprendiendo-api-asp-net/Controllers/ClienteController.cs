using Microsoft.AspNetCore.Mvc;

namespace aprendiendo_api_asp_net.Controllers
{
    public class ClienteController : ControllerBase
    {
        public ClienteController() { }

        [HttpGet]
        [Route("cliente")]
        public dynamic listarCliente()
        {
            return new {
                nombre = "Wilgen García",
            };
        }
    }
}
