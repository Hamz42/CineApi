using MC.Cine.BLL.Base;
using MC.Cine.BLL.Interfaces.Services;
using Microsoft.AspNetCore.Mvc;

namespace MC.Cine.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TipoDocumentoController : ControllerBase
    {
        private readonly ITipoDocumentoServices _tipoDocumentoServices; 

        public TipoDocumentoController(ITipoDocumentoServices tipoDocumentoServices)
        {
            _tipoDocumentoServices = tipoDocumentoServices;
        }

        /// <summary>
        /// /Devuelve todos los tipos de documentos
        /// </summary>
        /// <returns></returns>
        /// <Autor>Harold Andres Zamora</Autor>
        /// <Correo>hamz42@hotmail.com</Correo>
        /// <Fecha>15 de Abril de 2024</Fecha>
        /// <UltimaActualizacion>15 de Abril de 2024 - Harold Andres Zamora - Creación del servicio</UltimaActualizacion>
        [HttpGet("listar-tipo-documentos")]
        public IActionResult GetAll()
        {
            var model = _tipoDocumentoServices.GetAll();
            if (model == null)
            {
                return Ok(CreateResponse.ResponseNotOk());
            }
            return Ok(CreateResponse.ResponseOk(model));
        }

    }
}
