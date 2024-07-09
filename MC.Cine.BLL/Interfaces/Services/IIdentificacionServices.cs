using MC.Cine.DTO.Dto.Identificacion;

namespace MC.Cine.BLL.Interfaces.Services
{
    public interface IIdentificacionServices
    {
        IEnumerable<TipoIdentificacionDto> GetAll();
    }
}
