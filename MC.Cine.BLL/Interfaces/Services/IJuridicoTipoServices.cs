using MC.Cine.DTO.Dto.JuridicoTipo;
using MC.Cine.DTO.Dto.Moneda;

namespace MC.Cine.BLL.Interfaces.Services
{
    public interface IJuridicoTipoServices
    {
        IEnumerable<JuridicoTipoDto> GetAll();
    }
}
