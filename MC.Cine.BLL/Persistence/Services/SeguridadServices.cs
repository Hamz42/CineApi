using MC.Cine.BLL.Interfaces.Repository;
using MC.Cine.BLL.Interfaces.Services;
using MC.Cine.DTO.Dto.Seguridad;

namespace MC.Cine.BLL.Persistence.Services
{
    public class SeguridadServices : ISeguridadServices
    {
        private readonly ISeguridadRepository _seguridadRepository;

        public SeguridadServices(ISeguridadRepository seguridadRepository)
        {
            _seguridadRepository = seguridadRepository;
        }

        /// <summary>
        /// Obtiene las acciones por estados de un perfil
        /// </summary>
        /// <param name="request"></param>
        /// <returns>Lista de tipo "PermisosAccionesPorEstadosDto"</returns>
        /// <Autor>Harold Andres Zamora</Autor>
        /// <Correo>hamz42@hotmail.com</Correo>
        /// <Fecha>20 de Junio de 2024</Fecha>
        /// <UltimaActualizacion>20 de Junio de 2024 - Harold Andres Zamora - Creación del servicio</UltimaActualizacion>
        public IEnumerable<PermisosAccionesPorEstadosDto> GetAccionesPorEstados(PermisosRequest request)
        {
            return _seguridadRepository.GetAccionesPorEstados(request);
        }

        /// <summary>
        /// Obtiene los estados por perfil y modulo
        /// </summary>
        /// <param name="request"></param>
        /// <returns>Lista de tipo "PermisosEstadosPorPerfilModuloDto"</returns>
        /// <Autor>Harold Andres Zamora</Autor>
        /// <Correo>hamz42@hotmail.com</Correo>
        /// <Fecha>20 de Junio de 2024</Fecha>
        /// <UltimaActualizacion>20 de Junio de 2024 - Harold Andres Zamora - Creación del servicio</UltimaActualizacion>
        public IEnumerable<PermisosEstadosPorPerfilModuloDto> GetEstadosPorPerfilModuloDto(PermisosRequest request)
        {
           return _seguridadRepository.GetEstadosPorPerfilModuloDto(request);
        }
    }
}
