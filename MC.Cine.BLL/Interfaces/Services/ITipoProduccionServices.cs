using MC.Cine.DTO.Dto.Produccion;

namespace MC.Cine.BLL.Interfaces.Services
{
    public interface ITipoProduccionServices
    {
        IEnumerable<TipoProduccionDto> GetAll();
    }
}
