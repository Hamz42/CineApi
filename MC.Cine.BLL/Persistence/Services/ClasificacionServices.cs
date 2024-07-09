using MC.Cine.BLL.Interfaces.Repository;
using MC.Cine.BLL.Interfaces.Services;
using MC.Cine.DTO.Dto.Clasificacion;

namespace MC.Cine.BLL.Persistence.Services
{
    public class ClasificacionServices : IClasificacionServices
    {
        private IClasificacionRepository _clasificacionRepository;

        public ClasificacionServices(IClasificacionRepository clasificacionRepository)
        {
            _clasificacionRepository = clasificacionRepository;
        }

        public IEnumerable<ClasificacionDto> GetAllFiltros(FiltroClasificacionRequest request)
        {
            return _clasificacionRepository.GetAllFiltros(request);
        }
    }
}
