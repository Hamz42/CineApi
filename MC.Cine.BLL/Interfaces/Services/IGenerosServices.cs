using MC.Cine.DTO.Dto.Genero;

namespace MC.Cine.BLL.Interfaces.Services
{
    public interface IGenerosServices
    {
        IEnumerable<GeneroDto> GetAll();
    }
}
