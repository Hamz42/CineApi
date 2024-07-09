using MC.Cine.DTO.Dto.Pais;

namespace MC.Cine.BLL.Interfaces.Services
{
    public interface IPaisesServices
    {
        IEnumerable<PaisDto> GetAll();
    }
}
