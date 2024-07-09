using MC.Cine.DTO.Dto.Municipio;

namespace MC.Cine.BLL.Interfaces.Services
{
    public interface IMunicipioServices
    {
        IEnumerable<MunicipioDto> GetAll();
        IEnumerable<MunicipioDto> GetByDepartamentoId(int departamentoId);
    }
}

