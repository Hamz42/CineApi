using AutoMapper;
using MC.Cine.BLL.Base;
using MC.Cine.BLL.Interfaces.Services;
using MC.Cine.DTO.Dto.Autenticacion;
using Microsoft.AspNetCore.Mvc;
using MC.Cine.DTO.Dto.TramitesClasificacionNivel;
using Microsoft.AspNetCore.JsonPatch.Internal;
using Microsoft.AspNetCore.Authorization;
using MC.Cine.DTO.Dto.Moneda;

namespace MC.Cine.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TramitesClasificacionNivelController : ControllerBase
    {
        private readonly ITramitesClasificacionNivelServices _tramitesClasificacionNivelServices;

        public TramitesClasificacionNivelController(ITramitesClasificacionNivelServices tramitesClasificacionNivelServices)
        {
            _tramitesClasificacionNivelServices = tramitesClasificacionNivelServices;
        }


        /// <summary>
        /// Devuelve lista de tramitesClasificacionNivel
        /// </summary>
        /// <returns></returns>
        /// <Autor>DANILO AYALA</Autor>
        /// <Correo>dayalab@mincultura.com</Correo>
        /// <Fecha>20 de junio 2024</Fecha>
        /// <UltimaActualizacion>20 de junio 2024 - DANILO AYALA - Creacion de Listados Generales tramitesClasificacionNivel</UltimaActualizacion>


        [HttpGet("lista-clasificacion-nivel")]
        public ActionResult<IEnumerable<TramitesClasificacionNivelDto>> GetTramitesClasificacionNivel()
        {
            var tramitesClasificacionNivel = _tramitesClasificacionNivelServices.GetAll();

            if (tramitesClasificacionNivel == null)
            {
                return Ok(CreateResponse.ResponseNotOk());
            }

            return Ok(CreateResponse.ResponseOk(tramitesClasificacionNivel)); 
        }

        /// <summary>
        /// Devuelve lista de tramitesClasificacionNivel activos
        /// </summary>
        /// <returns>Lista de tipo "TramitesClasificacionNivelDto"</returns>
        /// <Autor>Harold Andres Zamora</Autor>
        /// <Correo>hamz42@hotmail.com</Correo>
        /// <Fecha>24 de Junio de 2024</Fecha>
        /// <UltimaActualizacion>24 de Junio de 2024 - Harold Andres Zamora - Creación del servicio</UltimaActualizacion>
        [HttpGet("lista-clasificacion-nivel-activos")]
        public ActionResult<IEnumerable<TramitesClasificacionNivelDto>> GetTramitesClasificacionNivelActivos()
        {
            var tramitesClasificacionNivel = _tramitesClasificacionNivelServices.GetAllActivos();

            if (tramitesClasificacionNivel == null)
            {
                return Ok(CreateResponse.ResponseNotOk());
            }

            return Ok(CreateResponse.ResponseOk(tramitesClasificacionNivel));
        }
    }
}
