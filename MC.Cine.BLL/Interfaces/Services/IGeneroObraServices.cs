using MC.Cine.DTO.Dto.GeneroObra;
using MC.Cine.DTO.Dto.Moneda;

namespace MC.Cine.BLL.Interfaces.Services
{
    public interface IGeneroObraServices
    {
        IEnumerable<GeneroObraDto> GetAll();
        IEnumerable<GeneroObraDto> GetAllActivos();
    }
}
