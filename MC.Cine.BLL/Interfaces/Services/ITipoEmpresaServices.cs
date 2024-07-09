using MC.Cine.DTO.Dto.Empresa;

namespace MC.Cine.BLL.Interfaces.Services
{
    public interface ITipoEmpresaServices
    {
        IEnumerable<TipoEmpresaDto> GetAll();
    }
}
