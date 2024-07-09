using MC.Cine.DTO.Dto.Proyecto;

namespace MC.Cine.BLL.Interfaces.Services
{
    public interface IProyectoServices
    {
        IEnumerable<ProyectoDto> GetAllFiltros(FiltroRequest request);
    }
}
