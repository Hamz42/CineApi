using AutoMapper;
using MC.Cine.BLL.Base;
using MC.Cine.BLL.Interfaces.Services;
using MC.Cine.DTO.Dto.Autenticacion;
using Microsoft.AspNetCore.Mvc;
using MC.Cine.DTO.Dto.Etnia;
using Microsoft.AspNetCore.JsonPatch.Internal;
using Microsoft.AspNetCore.Authorization;
using MC.Cine.BLL.Persistence.Services;
using MC.Cine.DTO.Dto.TramitesClasificacionNivel;


namespace MC.Cine.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EtniasController : ControllerBase
    {
        private readonly IEtniasServices _etniasServices;

        public EtniasController(IEtniasServices etniasServices)
        {
            _etniasServices = etniasServices;
        }


        /// <summary>
        /// Devuelve lista de etnias
        /// </summary>
        /// <returns></returns>
        /// <Autor>DANILO AYALA</Autor>
        /// <Correo>dayalab@mincultura.com</Correo>
        /// <Fecha>26 de junio 2024</Fecha>
        /// <UltimaActualizacion>26 de junio 2024 - DANILO AYALA - Creacion de Listados Generales etnias</UltimaActualizacion>


        [HttpGet("Lista-Etnias")]
        public ActionResult<IEnumerable<EtniasDto>> GetEtnias()
        {
            var etnias = _etniasServices.GetAll();

            if (etnias == null)
            {
                return Ok(CreateResponse.ResponseNotOk());
            }

            return Ok(CreateResponse.ResponseOk(etnias)); 
        }
        /// <summary>
        /// Devuelve lista de etnias activos
        /// </summary>
        /// <returns>Lista de tipo "etniasDto"</returns>
        /// <Autor>DANILO AYALA</Autor>
        /// <Correo>dayalab@mincultura.com</Correo>
        /// <Fecha>26 de Junio de 2024</Fecha>
        /// <UltimaActualizacion>26 de Junio de 2024 - DANILO AYALA - Creación del servicio</UltimaActualizacion>
        [HttpGet("Lista-Etnias-Activos")]
        public ActionResult<IEnumerable<EtniasDto>> GetEtniasActivos()
        {
            var EtniasActivos = _etniasServices.GetAllActivos();

            if (EtniasActivos == null)
            {
                return Ok(CreateResponse.ResponseNotOk());
            }

            return Ok(CreateResponse.ResponseOk(EtniasActivos));
        }
    }
}
