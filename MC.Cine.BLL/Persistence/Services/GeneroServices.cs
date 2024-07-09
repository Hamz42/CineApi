using MC.Cine.BLL.Interfaces.Repository;
using MC.Cine.BLL.Interfaces.Services;
using MC.Cine.DTO.Dto.Genero;

namespace MC.Cine.BLL.Persistence.Services
{
    public class GeneroServices : IGeneroServices
    {
        private readonly IGeneroRepository _generoRepository;

        public GeneroServices(IGeneroRepository generoRepository)
        {
            _generoRepository = generoRepository;
        }

        public IEnumerable<GeneroDto> GetAll()
        {
            var lista = _generoRepository.GetAll();

            return lista.Select(x => new GeneroDto
            {
                Id = x.IdGenero,
                Nombre = x.Nombre ?? string.Empty   
            }).ToList();
        }
    }
}
