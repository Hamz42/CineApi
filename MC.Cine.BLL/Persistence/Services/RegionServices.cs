using MC.Cine.BLL.Interfaces.Repository;
using MC.Cine.BLL.Interfaces.Services;
using MC.Cine.DTO.Dto.Region;

namespace MC.Cine.BLL.Persistence.Services
{
    public class RegionServices : IRegionServices
    {
        private readonly IRegionRepository _regionRepository;   

        public RegionServices(IRegionRepository regionRepository)
        {
            _regionRepository = regionRepository;
        }

        public IEnumerable<RegionDto> Get(int idPadre)
        {
            var regiones = _regionRepository.Get(x => x.IdRegionPadre == idPadre);
            return regiones.Select(x => new RegionDto
            {
                Id = x.IdRegion,
                Nombre = x.NombreRegion
            }).ToList();
        }
    }
}
