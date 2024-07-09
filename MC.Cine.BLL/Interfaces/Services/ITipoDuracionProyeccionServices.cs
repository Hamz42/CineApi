using MC.Cine.DTO.Dto.Moneda;
using MC.Cine.DTO.Dto.TipoDuracionProyeccion;

namespace MC.Cine.BLL.Interfaces.Services
{
    public interface ITipoDuracionProyeccionServices
    {
        IEnumerable<TipoDuracionProyeccionDto> GetAll();
        IEnumerable<TipoDuracionProyeccionDto> GetAllActivos();
    }
}
