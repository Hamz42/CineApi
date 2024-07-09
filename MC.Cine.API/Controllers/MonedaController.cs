using AutoMapper;
using MC.Cine.BLL.Base;
using MC.Cine.BLL.Interfaces.Services;
using MC.Cine.DTO.Dto.Autenticacion;
using Microsoft.AspNetCore.Mvc;
using MC.Cine.DTO.Dto.Moneda;
using Microsoft.AspNetCore.JsonPatch.Internal;
using Microsoft.AspNetCore.Authorization;
using MC.Cine.BLL.Persistence.Services;
using MC.Cine.DTO.Dto.TramitesClasificacionNivel;


namespace MC.Cine.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MonedaController : ControllerBase
    {
        private readonly IMonedaServices _monedaServices;

        public MonedaController(IMonedaServices monedaServices)
        {
            _monedaServices = monedaServices;
        }


        /// <summary>
        /// Devuelve lista de moneda
        /// </summary>
        /// <returns></returns>
        /// <Autor>DANILO AYALA</Autor>
        /// <Correo>dayalab@mincultura.com</Correo>
        /// <Fecha>20 de junio 2024</Fecha>
        /// <UltimaActualizacion>20 de junio 2024 - DANILO AYALA - Creacion de Listados Generales moneda</UltimaActualizacion>


        [HttpGet("Lista-Moneda")]
        public ActionResult<IEnumerable<MonedaDto>> GetMoneda()
        {
            var moneda = _monedaServices.GetAll();

            if (moneda == null)
            {
                return Ok(CreateResponse.ResponseNotOk());
            }

            return Ok(CreateResponse.ResponseOk(moneda)); 
        }
        /// <summary>
        /// Devuelve lista de Moneda activos
        /// </summary>
        /// <returns>Lista de tipo "MonedaDto"</returns>
        /// <Autor>DANILO AYALA</Autor>
        /// <Correo>dayalab@mincultura.com</Correo>
        /// <Fecha>25 de Junio de 2024</Fecha>
        /// <UltimaActualizacion>25 de Junio de 2024 - DANILO AYALA - Creación del servicio</UltimaActualizacion>
        [HttpGet("Lista-Moneda-Activos")]
        public ActionResult<IEnumerable<MonedaDto>> GetMonedaActivos()
        {
            var MonedaActivos = _monedaServices.GetAllActivos();

            if (MonedaActivos == null)
            {
                return Ok(CreateResponse.ResponseNotOk());
            }

            return Ok(CreateResponse.ResponseOk(MonedaActivos));
        }
    }
}
