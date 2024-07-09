using MC.Cine.DTO.Dto.Genero;

namespace MC.Cine.BLL.Interfaces.Services
{
    public interface IGeneroServices
    {
        IEnumerable<GeneroDto> GetAll();
    }
}
