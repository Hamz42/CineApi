using AutoMapper;
using MC.Cine.BLL.Base;
using MC.Cine.BLL.Interfaces.Services;
using MC.Cine.DTO.Dto.Autenticacion;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.JsonPatch.Internal;
using Microsoft.AspNetCore.Authorization;
using MC.Cine.BLL.Persistence.Services;
using MC.Cine.DTO.Dto.TramitesClasificacionNivel;
using MC.Cine.DTO.Dto.JuridicoTipo;


namespace MC.Cine.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class JuridicoTipoController : ControllerBase
    {
        private readonly IJuridicoTipoServices _juridicoTipoServices;

        public JuridicoTipoController(IJuridicoTipoServices juridicoTipoServices)
        {
            _juridicoTipoServices = juridicoTipoServices;
        }


        /// <summary>
        /// Devuelve lista de Juridico Tipo
        /// </summary>
        /// <returns></returns>
        /// <Autor>DANILO AYALA</Autor>
        /// <Correo>dayalab@mincultura.com</Correo>
        /// <Fecha>26 de junio 2024</Fecha>
        /// <UltimaActualizacion>26 de junio 2024 - DANILO AYALA - Creacion de Listados Generales Juridico Tipo</UltimaActualizacion>


        [HttpGet("Lista-Juridico-Tipo")]
        public ActionResult<IEnumerable<JuridicoTipoDto>> GetJuridicoTipo()
        {
            var juridicoTipo = _juridicoTipoServices.GetAll();

            if (juridicoTipo == null)
            {
                return Ok(CreateResponse.ResponseNotOk());
            }

            return Ok(CreateResponse.ResponseOk(juridicoTipo)); 
        }
        
    }
}
