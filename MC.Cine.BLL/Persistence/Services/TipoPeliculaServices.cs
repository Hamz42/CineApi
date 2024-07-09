using MC.Cine.BLL.Interfaces.Repository;
using MC.Cine.BLL.Interfaces.Services;
using MC.Cine.DTO.Dto.TipoPelicula;

namespace MC.Cine.BLL.Persistence.Services
{
    public class TipoPeliculaServices : ITipoPeliculaServices
    {
        private ITipoPeliculaRepository _tipoPeliculaRepository;
        public TipoPeliculaServices(ITipoPeliculaRepository tipoPeliculaRepository)
        {
            _tipoPeliculaRepository = tipoPeliculaRepository;
        }

        /// <summary>
        /// //Obtiene todos los tipos de pelicula activos
        /// </summary>
        /// <returns></returns>
        /// <Autor>Harold Andres Zamora</Autor>
        /// <Correo>hamz42@hotmail.com</Correo>
        /// <Fecha>01 de Julio de 2024</Fecha>
        /// <UltimaActualizacion>01 de Julio de 2024 - Harold Andres Zamora - Creación del servicio</UltimaActualizacion>
        public IEnumerable<TipoPeliculaDto> GetAllActivos()
        {
            var fechaActual = DateTime.Now;
            var lista = _tipoPeliculaRepository.Get(x => !x.FechaBaja.HasValue || x.FechaBaja > fechaActual);

            return lista.Select(x => new TipoPeliculaDto
            {
                Id = x.Id,
                TipoPelicula = x.TipoPelicula
            }).ToList();
        }
    }
}
