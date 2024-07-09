using MC.Cine.DTO.Dto.Etnia;

namespace MC.Cine.BLL.Interfaces.Services
{
    public interface IEtniasServices
    {
        IEnumerable<EtniasDto> GetAll();
        IEnumerable<EtniasDto> GetAllActivos();
    }
}
