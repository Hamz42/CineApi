using MC.Cine.BLL.Base;
using MC.Cine.BLL.Interfaces.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace MC.Cine.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class AgentesController : ControllerBase
    {
        private readonly IAgentesServices _agentesServices;

        public AgentesController(IAgentesServices agentesServices)
        {
            _agentesServices = agentesServices;
        }

        /// <summary>
        /// Devuelve lista de agentes filtrada por tipo de agente
        /// </summary>
        /// <param name="agenteTipoId"></param>
        /// <returns></returns>
        /// <Autor>Harold Andres Zamora</Autor>
        /// <Correo>hamz42@hotmail.com</Correo>
        /// <Fecha>01 de Julio de 2024</Fecha>
        /// <UltimaActualizacion>01 de Julio de 2024 - Harold Andres Zamora - Creación del servicio</UltimaActualizacion>
        [HttpGet("consultar-agentes-por-tipo-agente/agenteTipoId/{agenteTipoId}")]
        public IActionResult GetAllByAgenteTipo(int agenteTipoId)
        {
            var persona = _agentesServices.GetAllByAgenteTipo(agenteTipoId);
            if (persona == null)
            {
                return Ok(CreateResponse.ResponseNotOk());
            }
            return Ok(CreateResponse.ResponseOk(persona));
        }
    }
}
