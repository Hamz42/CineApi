using MC.Cine.DTO.Dto.EstadosTramite;

namespace MC.Cine.BLL.Interfaces.Services
{
    public interface IEstadosServices
    {
        IEnumerable<EstadosDto> GetAllEstados();
    }
}
