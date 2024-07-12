using MC.Cine.DTO.Dto.Clasificacion.TipoVisualizacion;

namespace MC.Cine.BLL.Interfaces.Services
{
    public interface ITipoVisualizacionServices
    {
        IEnumerable<TipoVisualizacionDto> GetAllActivos();
    }
}
