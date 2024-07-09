using MC.Cine.BLL.Base;
using MC.Cine.BLL.Interfaces.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace MC.Cine.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class TipoPeliculaController : ControllerBase
    {
        private readonly ITipoPeliculaServices _tipoPeliculaServices;

        public TipoPeliculaController(ITipoPeliculaServices tipoPeliculaServices)
        {
            _tipoPeliculaServices = tipoPeliculaServices;
        }

        /// <summary>
        /// //Obtiene todos los tipos de pelicula activos
        /// </summary>
        /// <returns></returns>
        /// <Autor>Harold Andres Zamora</Autor>
        /// <Correo>hamz42@hotmail.com</Correo>
        /// <Fecha>01 de Julio de 2024</Fecha>
        /// <UltimaActualizacion>01 de Julio de 2024 - Harold Andres Zamora - Creación del servicio</UltimaActualizacion>
        [HttpGet("lista-tipos-activos")]
        public IActionResult GetAllActivos()
        {
            var TipoPelicula = _tipoPeliculaServices.GetAllActivos();

            if (TipoPelicula == null)
            {
                return Ok(CreateResponse.ResponseNotOk());
            }

            return Ok(CreateResponse.ResponseOk(TipoPelicula));
        }
    }
}
