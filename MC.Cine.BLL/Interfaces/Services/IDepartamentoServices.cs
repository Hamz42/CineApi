using MC.Cine.DTO.Dto.Departamento;

namespace MC.Cine.BLL.Interfaces.Services
{
    public interface IDepartamentoServices
    {
        IEnumerable<DepartamentoDto> GetAll();
        IEnumerable<DepartamentoDto> GetByPaisId(int paisId);
    }
}
