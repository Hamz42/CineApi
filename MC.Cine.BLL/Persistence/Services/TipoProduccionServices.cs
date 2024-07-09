using MC.Cine.BLL.Interfaces.Repository;
using MC.Cine.BLL.Interfaces.Services;
using MC.Cine.DTO.Dto.Produccion;

namespace MC.Cine.BLL.Persistence.Services
{
    public class TipoProduccionServices : ITipoProduccionServices
    {
        private readonly ITipoProduccionRepository _tipoProduccionRepository;

        public TipoProduccionServices(ITipoProduccionRepository tipoProduccionRepository)
        {
            _tipoProduccionRepository = tipoProduccionRepository;
        }
        public IEnumerable<TipoProduccionDto> GetAll()
        {
            var tiposProduccion = _tipoProduccionRepository.GetAll();

            return tiposProduccion.Select(x => new TipoProduccionDto
            {
                Id = x.CodTipoProduccion,
                Nombre = x.NombreTipoProduccion
            }).ToList();
        }
    }
}
