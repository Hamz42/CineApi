using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using AutoMapper;
using MC.Cine.BLL.Base;
using MC.Cine.BLL.Interfaces.Services;
using MC.Cine.DTO.Dto.Autenticacion;
using MC.Cine.DTO.Dto.Identificacion;
using Microsoft.AspNetCore.JsonPatch.Internal;
using Microsoft.AspNetCore.Authorization;
using MC.Cine.BLL.Persistence.Services;

namespace MC.Cine.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class IdentificacionController : ControllerBase
    {
        private readonly IIdentificacionServices _identificacionServices;

        public IdentificacionController(IIdentificacionServices identificacionServices)
        {
            _identificacionServices = identificacionServices;
        }


        /// <summary>
        /// Devuelve lista de identificacion
        /// </summary>
        /// <returns></returns>
        /// <Autor>DANILO AYALA</Autor>
        /// <Correo>dayalab@mincultura.com</Correo>
        /// <Fecha>20 de junio 2024</Fecha>
        /// <UltimaActualizacion>20 de junio 2024 - DANILO AYALA - Creacion de Listados Generales identificacion</UltimaActualizacion>


        [HttpGet("Lista-Identificacion")]
        public ActionResult<IEnumerable<TipoIdentificacionDto>> GetIndentificacion()
        {
            var identificacion = _identificacionServices.GetAll();

            if (identificacion == null)
            {
                return Ok(CreateResponse.ResponseNotOk());
            }

            return Ok(CreateResponse.ResponseOk(identificacion));
        }
    }
}