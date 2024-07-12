using MC.Cine.BLL.Base;
using MC.Cine.BLL.Interfaces.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace MC.Cine.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class TipoVisualizacionController : ControllerBase
    {
        private readonly ITipoVisualizacionServices _tipoVisualizacionServices;

        public TipoVisualizacionController(ITipoVisualizacionServices tipoVisualizacionServices)
        {
            _tipoVisualizacionServices = tipoVisualizacionServices;
        }

        /// <summary>
        /// Obtiene todos los tipos de visualizacion activos
        /// </summary>
        /// <returns></returns>
        /// <Autor>Harold Andres Zamora</Autor>
        /// <Correo>hamz42@hotmail.com</Correo>
        /// <Fecha>01 de Julio de 2024</Fecha>
        /// <UltimaActualizacion>01 de Julio de 2024 - Harold Andres Zamora - Creación del servicio</UltimaActualizacion>
        [HttpGet("lista-activos")]
        public IActionResult GetAllActivos()
        {
            var model = _tipoVisualizacionServices.GetAllActivos();
            if (model == null)
            {
                return Ok(CreateResponse.ResponseNotOk());
            }
            return Ok(CreateResponse.ResponseOk(model));
        }
    }
}
