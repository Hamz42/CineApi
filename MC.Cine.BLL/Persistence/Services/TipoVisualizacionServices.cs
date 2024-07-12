using MC.Cine.BLL.Interfaces.Repository;
using MC.Cine.BLL.Interfaces.Services;
using MC.Cine.DTO.Dto.Clasificacion.TipoVisualizacion;

namespace MC.Cine.BLL.Persistence.Services
{
    public class TipoVisualizacionServices : ITipoVisualizacionServices
    {
        ITipoVisualizacionRepository _tipoVisualizacionRepository;

        public TipoVisualizacionServices(ITipoVisualizacionRepository tipoVisualizacionRepository)
        {
            _tipoVisualizacionRepository = tipoVisualizacionRepository;
        }

        /// <summary>
        /// Obtiene todos los tipos de visualizacion activos
        /// </summary>
        /// <returns></returns>
        /// <Autor>Harold Andres Zamora</Autor>
        /// <Correo>hamz42@hotmail.com</Correo>
        /// <Fecha>01 de Julio de 2024</Fecha>
        /// <UltimaActualizacion>01 de Julio de 2024 - Harold Andres Zamora - Creación del servicio</UltimaActualizacion>
        public IEnumerable<TipoVisualizacionDto> GetAllActivos()
        {
            var fechaActual = DateTime.Now;
            var lista = _tipoVisualizacionRepository.Get(x => !x.FechaBaja.HasValue || x.FechaBaja > fechaActual);

            return lista.Select(x => new TipoVisualizacionDto
            {
                Id = x.Id,
                TipoVisualizacion = x.TipoVisualizacion
            }).ToList();
        }
    }
}
