using MC.Cine.BLL.Base;
using MC.Cine.BLL.Interfaces.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MC.Cine.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TipoProductorController : ControllerBase
    {
        private readonly ITipoProductorServices _tipoProductorServices; 

        public TipoProductorController(ITipoProductorServices tipoProductorServices)
        {
            _tipoProductorServices = tipoProductorServices;
        }

        /// <summary>
        /// /Devuelve todos los tipos de productores
        /// </summary>
        /// <returns></returns>
        /// <Autor>Harold Andres Zamora</Autor>
        /// <Correo>hamz42@hotmail.com</Correo>
        /// <Fecha>15 de Abril de 2024</Fecha>
        /// <UltimaActualizacion>15 de Abril de 2024 - Harold Andres Zamora - Creación del servicio</UltimaActualizacion>
        [HttpGet]
        public IActionResult GetAll()
        {
            var model = _tipoProductorServices.GetAll();
            if (model == null)
            {
                return Ok(CreateResponse.ResponseNotOk());
            }
            return Ok(CreateResponse.ResponseOk(model));
        }
    }
}
