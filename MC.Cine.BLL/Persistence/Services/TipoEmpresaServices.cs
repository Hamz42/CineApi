using MC.Cine.BLL.Interfaces.Repository;
using MC.Cine.BLL.Interfaces.Services;
using MC.Cine.DTO.Dto.Empresa;

namespace MC.Cine.BLL.Persistence.Services
{
    public class TipoEmpresaServices : ITipoEmpresaServices
    {
        private readonly ITipoEmpresaRepository _tipoEmpresaRepository;

        public TipoEmpresaServices(ITipoEmpresaRepository tipoEmpresaRepository)
        {
            _tipoEmpresaRepository = tipoEmpresaRepository;
        }

        public IEnumerable<TipoEmpresaDto> GetAll()
        {
            var tipoEmpresas = _tipoEmpresaRepository.Get(x => x.CodTipoEmpresa != 7);

            return tipoEmpresas.Select(x => new TipoEmpresaDto
            {
                Id = x.CodTipoEmpresa,
                Nombre = x.NombreTipoEmpresa
            }).OrderBy(x => x.Nombre).ToList();
        }
    }
}
