using MC.Cine.BLL.Base;
using MC.Cine.BLL.Interfaces.Services;
using Microsoft.AspNetCore.Mvc;

namespace MC.Cine.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GeneroController : ControllerBase
    {
        private readonly IGeneroServices _generoServices;

        public GeneroController(IGeneroServices generoServices)
        {
            _generoServices = generoServices;
        }

        /// <summary>
        /// Devuelve todos los géneros
        /// </summary>
        /// <returns></returns>
        /// <Autor>Harold Andres Zamora</Autor>
        /// <Correo>hamz42@hotmail.com</Correo>
        /// <Fecha>15 de Abril de 2024</Fecha>
        /// <UltimaActualizacion>15 de Abril de 2024 - Harold Andres Zamora - Creación del servicio</UltimaActualizacion>
        [HttpGet("litar-gneros")]
        public IActionResult GetAll()
        {
            var model = _generoServices.GetAll();
            if (model == null)
            {
                return Ok(CreateResponse.ResponseNotOk());
            }
            return Ok(CreateResponse.ResponseOk(model));
        }
    }
}
