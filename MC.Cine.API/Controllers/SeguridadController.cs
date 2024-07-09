using MC.Cine.BLL.Base;
using MC.Cine.BLL.Interfaces.Services;
using MC.Cine.DTO.Dto.Seguridad;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace MC.Cine.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class SeguridadController : ControllerBase
    {
        private readonly ISeguridadServices _seguridadServices;

        public SeguridadController(ISeguridadServices seguridadServices)
        {
            _seguridadServices = seguridadServices;
        }

        /// <summary>
        /// Obtiene las acciones por estados de un perfil
        /// </summary>
        /// <param name="request"></param>
        /// <returns>Lista de tipo "PermisosAccionesPorEstadosDto"</returns>
        /// <Autor>Harold Andres Zamora</Autor>
        /// <Correo>hamz42@hotmail.com</Correo>
        /// <Fecha>20 de Junio de 2024</Fecha>
        /// <UltimaActualizacion>20 de Junio de 2024 - Harold Andres Zamora - Creación del servicio</UltimaActualizacion>
        [HttpPost("acciones-por-estados")]
        public IActionResult GetAccionesPorEstados([FromBody] PermisosRequest request)
        {
            var model = _seguridadServices.GetAccionesPorEstados(request);
            if (model == null)
            {
                return Ok(CreateResponse.ResponseNotOk());
            }
            return Ok(CreateResponse.ResponseOk(model));
        }

        /// <summary>
        /// Obtiene los estados por perfil y modulo
        /// </summary>
        /// <param name="request"></param>
        /// <returns>Lista de tipo "PermisosEstadosPorPerfilModuloDto"</returns>
        /// <Autor>Harold Andres Zamora</Autor>
        /// <Correo>hamz42@hotmail.com</Correo>
        /// <Fecha>20 de Junio de 2024</Fecha>
        /// <UltimaActualizacion>20 de Junio de 2024 - Harold Andres Zamora - Creación del servicio</UltimaActualizacion>
        [HttpPost("estados-por-perfil-modulo")]
        public IActionResult GetEstadosPorPerfilModulo([FromBody] PermisosRequest request)
        {
            var model = _seguridadServices.GetEstadosPorPerfilModuloDto(request);
            if (model == null)
            {
                return Ok(CreateResponse.ResponseNotOk());
            }
            return Ok(CreateResponse.ResponseOk(model));

        }
    }
}
