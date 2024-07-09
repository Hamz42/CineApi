using AutoMapper;
using MC.Cine.BLL.Base;
using MC.Cine.BLL.Interfaces.Services;
using MC.Cine.DTO.Dto.Autenticacion;
using Microsoft.AspNetCore.Mvc;
using MC.Cine.DTO.Dto.GrupoPoblacional;
using Microsoft.AspNetCore.JsonPatch.Internal;
using Microsoft.AspNetCore.Authorization;
using MC.Cine.BLL.Persistence.Services;
using MC.Cine.DTO.Dto.TramitesClasificacionNivel;

namespace MC.Cine.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GrupoPoblacionalController : ControllerBase
    {
        private readonly IGrupoPoblacionalServices _grupoPoblacionalServices;

        public GrupoPoblacionalController(IGrupoPoblacionalServices grupoPoblacionalServices)
        {
            _grupoPoblacionalServices = grupoPoblacionalServices;
        }

        /// <summary>
        /// Devuelve lista de moneda
        /// </summary>
        /// <returns></returns>
        /// <Autor>DANILO AYALA</Autor>
        /// <Correo>dayalab@mincultura.com</Correo>
        /// <Fecha>26 de junio 2024</Fecha>
        /// <UltimaActualizacion>26 de junio 2024 - DANILO AYALA - Creacion de Listados Generales moneda</UltimaActualizacion>


        [HttpGet("Lista-Grupo-Poblacional")]
        public ActionResult<IEnumerable<GrupoPoblacionalDto>> GetGrupoPoblacional()
        {
            var GrupoPoblacional = _grupoPoblacionalServices.GetAll();

            if (GrupoPoblacional == null)
            {
                return Ok(CreateResponse.ResponseNotOk());
            }

            return Ok(CreateResponse.ResponseOk(GrupoPoblacional));
        }
        /// <summary>
        /// Devuelve lista de GrupoPoblacional activos
        /// </summary>
        /// <returns>Lista de tipo "GrupoPoblacionalDto"</returns>
        /// <Autor>DANILO AYALA</Autor>
        /// <Correo>dayalab@mincultura.com</Correo>
        /// <Fecha>26 de Junio de 2024</Fecha>
        /// <UltimaActualizacion>26 de Junio de 2024 - DANILO AYALA - Creación del servicio</UltimaActualizacion>
        [HttpGet("Lista-Grupo-Poblacional-Activos")]
        public ActionResult<IEnumerable<GrupoPoblacionalDto>> GetGrupoPoblacionalActivos()
        {
            var grupoPoblacional = _grupoPoblacionalServices.GetAllActivos();

            if (grupoPoblacional == null)
            {
                return Ok(CreateResponse.ResponseNotOk());
            }

            return Ok(CreateResponse.ResponseOk(grupoPoblacional));
        }
    }
}
