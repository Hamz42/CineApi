using MC.Cine.BLL.Base;
using MC.Cine.BLL.Interfaces.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MC.Cine.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TipoProduccionController : ControllerBase
    {
        private readonly ITipoProduccionServices _tipoProduccionServices;

        public TipoProduccionController(ITipoProduccionServices tipoProduccionServices)
        {
            _tipoProduccionServices = tipoProduccionServices;
        }

        /// <summary>
        /// /Devuelve todos los tipos de produccion
        /// </summary>
        /// <returns></returns>
        /// <Autor>Harold Andres Zamora</Autor>
        /// <Correo>hamz42@hotmail.com</Correo>
        /// <Fecha>15 de Abril de 2024</Fecha>
        /// <UltimaActualizacion>15 de Abril de 2024 - Harold Andres Zamora - Creación del servicio</UltimaActualizacion>
        [HttpGet("listar-tipos-produccion")]
        public IActionResult GetAll()
        {
            var model = _tipoProduccionServices.GetAll();
            if (model == null)
            {
                return Ok(CreateResponse.ResponseNotOk());
            }
            return Ok(CreateResponse.ResponseOk(model));
        }
    }
}
