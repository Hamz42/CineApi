using MC.Cine.DTO.Dto.GrupoPoblacional;

namespace MC.Cine.BLL.Interfaces.Services
{
    public interface IGrupoPoblacionalServices
    {
        IEnumerable<GrupoPoblacionalDto> GetAll();
        IEnumerable<GrupoPoblacionalDto> GetAllActivos();
    }
}
