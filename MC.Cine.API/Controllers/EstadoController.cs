using MC.Cine.BLL.Base;
using MC.Cine.BLL.Interfaces.Services;
using Microsoft.AspNetCore.Mvc;

namespace MC.Cine.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EstadoController : ControllerBase
    {
        private readonly IEstadosServices _estadosservice;

        public EstadoController(IEstadosServices estadosServices)
        {
            _estadosservice = estadosServices;
        }

        [HttpGet]
        [Route("Consulta")]
        public IActionResult ConsultaEstadosTramite()
        {
            var model = _estadosservice.GetAllEstados();
            if (model == null)
            {
                return Ok(CreateResponse.ResponseNotOk());
            }
            return Ok(CreateResponse.ResponseOk(model));
        }
    }
}
