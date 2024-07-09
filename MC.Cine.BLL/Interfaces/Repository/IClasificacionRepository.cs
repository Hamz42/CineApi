using MC.Cine.DTO.Dto.Clasificacion;

namespace MC.Cine.BLL.Interfaces.Repository
{
    public interface IClasificacionRepository
    {
        IEnumerable<ClasificacionDto> GetAllFiltros(FiltroClasificacionRequest request);
    }
}
