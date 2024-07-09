using MC.Cine.DTO.Dto.TipoDocumento;

namespace MC.Cine.BLL.Interfaces.Services
{
    public interface ITipoDocumentoServices
    {
        IEnumerable<TipoDocumentoDto> GetAll();
    }
}
