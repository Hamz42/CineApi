using MC.Cine.DTO.Dto.Agentes;

namespace MC.Cine.BLL.Interfaces.Services
{
    public interface IAgentesServices
    {
        IEnumerable<AgentesDatosBasicosDto> GetAllByAgenteTipo(int agenteTipoId);
    }
}
