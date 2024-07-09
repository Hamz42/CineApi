using MC.Cine.BLL.Interfaces.Repository;
using MC.Cine.BLL.Interfaces.Services;
using MC.Cine.DTO.Dto.TipoDocumento;

namespace MC.Cine.BLL.Persistence.Services
{
    public class TipoDocumentoServices : ITipoDocumentoServices
    {
        private readonly ITipoDocumentoRepository _tipoDocumentoRepository;

        public TipoDocumentoServices(ITipoDocumentoRepository tipoDocumentoRepository)
        {
            _tipoDocumentoRepository = tipoDocumentoRepository;
        }

        public IEnumerable<TipoDocumentoDto> GetAll()
        {
            var tipoDocumentos = _tipoDocumentoRepository.GetAll();

            return tipoDocumentos.Select(x => new TipoDocumentoDto
            {
                Id = x.CodTipoDocumento,
                Nombre = x.NombreTipoDocumento
            }).OrderBy(x => x.Nombre).ToList();
        }
    }
}
