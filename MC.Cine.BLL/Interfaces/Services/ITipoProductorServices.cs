using MC.Cine.DTO.Dto.Productor;

namespace MC.Cine.BLL.Interfaces.Services
{
    public interface ITipoProductorServices
    {
        IEnumerable<TipoProductorDto> GetAll();
    }
}
