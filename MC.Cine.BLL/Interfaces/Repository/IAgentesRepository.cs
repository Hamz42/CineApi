using MC.Cine.DTO.Dto.Agentes;

namespace MC.Cine.BLL.Interfaces.Repository
{
    public interface IAgentesRepository
    {
        IEnumerable<AgentesDatosBasicosDto> GetAllByAgenteTipo(int agenteTipoId);
    }
}
