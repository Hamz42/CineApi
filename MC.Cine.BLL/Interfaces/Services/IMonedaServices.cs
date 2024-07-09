using MC.Cine.DTO.Dto.Moneda;

namespace MC.Cine.BLL.Interfaces.Services
{
    public interface IMonedaServices
    {
        IEnumerable<MonedaDto> GetAll();
        IEnumerable<MonedaDto> GetAllActivos();
    }
}
