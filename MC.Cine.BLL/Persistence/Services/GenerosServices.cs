using MC.Cine.BLL.Interfaces.Repository;
using MC.Cine.BLL.Interfaces.Services;
using MC.Cine.DTO.Dto.Genero;

namespace MC.Cine.BLL.Persistence.Services
{
    public class GenerosServices : IGenerosServices
    {
        private readonly IGenerosRepository _generosRepository;

        public GenerosServices(IGenerosRepository generosRepository)
        {
            _generosRepository = generosRepository;
        }

        /// <summary>
        /// Devuelve lista de Paises
        /// </summary>
        /// <returns></returns>
        /// <Autor>DANILO AYALA</Autor>
        /// <Correo>dayalab@mincultura.com</Correo>
        /// <Fecha>20 de junio 2024</Fecha>
        /// <UltimaActualizacion>20 de junio 2024 - DANILO AYALA - Creacion de Listados Generales Paises</UltimaActualizacion>

        public IEnumerable<GeneroDto> GetAll()
        {
            var lista = _generosRepository.GetAll();

            return lista.Select(x => new GeneroDto
            {
                Id = x.Id,
                Genero = x.Genero

            }).ToList();
        }

       
    }
}
