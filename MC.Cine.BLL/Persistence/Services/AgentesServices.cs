using MC.Cine.BLL.Interfaces.Repository;
using MC.Cine.BLL.Interfaces.Services;
using MC.Cine.DTO.Dto.Agentes;

namespace MC.Cine.BLL.Persistence.Services
{
    internal class AgentesServices : IAgentesServices
    {
        private IAgentesRepository _agentesRepository;

        public AgentesServices(IAgentesRepository agentesRepository)
        {
            _agentesRepository = agentesRepository;
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
        public IEnumerable<AgentesDatosBasicosDto> GetAllByAgenteTipo(int agenteTipoId)
        {
            return _agentesRepository.GetAllByAgenteTipo(agenteTipoId);
        }
    }
}
