using MC.Cine.BLL.Interfaces.Repository;
using MC.Cine.BLL.Interfaces.Services;
using MC.Cine.DTO.Dto.Productor;

namespace MC.Cine.BLL.Persistence.Services
{
    public class TipoProductorServices : ITipoProductorServices
    {
        private readonly ITipoProductorRepository _tipoProductorRepository;

        public TipoProductorServices(ITipoProductorRepository tipoProductorRepository)
        {
            _tipoProductorRepository = tipoProductorRepository;
        }

        public IEnumerable<TipoProductorDto> GetAll()
        {
            var tiposProductor = _tipoProductorRepository.GetAll();

            return tiposProductor.Select(x => new TipoProductorDto
            {
                Id = x.CodTipoProductor,
                Nombre = x.NombreTipoProductor
            }).ToList().ToList();
        }
    }
}
