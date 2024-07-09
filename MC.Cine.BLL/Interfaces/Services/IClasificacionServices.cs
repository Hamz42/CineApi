using MC.Cine.DTO.Dto.Clasificacion;

namespace MC.Cine.BLL.Interfaces.Services
{
    public interface IClasificacionServices
    {
        IEnumerable<ClasificacionDto> GetAllFiltros(FiltroClasificacionRequest request);
    }
}
