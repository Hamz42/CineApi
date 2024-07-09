using MC.Cine.DTO.Dto.TramitesClasificacionNivel;

namespace MC.Cine.BLL.Interfaces.Services
{
    public interface ITramitesClasificacionNivelServices
    {
        IEnumerable<TramitesClasificacionNivelDto> GetAll();
        IEnumerable<TramitesClasificacionNivelDto> GetAllActivos();
    }
}
