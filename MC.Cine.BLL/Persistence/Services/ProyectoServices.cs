using MC.Cine.BLL.Interfaces.Repository;
using MC.Cine.BLL.Interfaces.Services;
using MC.Cine.DTO.Dto.Proyecto;

namespace MC.Cine.BLL.Persistence.Services
{
    public class ProyectoServices : IProyectoServices
    {
        private IProyectoRepository _proyectoRepository;

        public ProyectoServices(IProyectoRepository proyectoRepository)
        {
            _proyectoRepository = proyectoRepository;
        }

        public IEnumerable<ProyectoDto> GetAllFiltros(FiltroRequest request)
        {
            return _proyectoRepository.GetAllFiltros(request);
        }
    }
}
