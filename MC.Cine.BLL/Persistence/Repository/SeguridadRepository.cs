using MC.Cine.BLL.Interfaces.Common.Base;
using MC.Cine.BLL.Interfaces.Repository;
using MC.Cine.DTO.Dto.Seguridad;

namespace MC.Cine.BLL.Persistence.Repository
{
    public class SeguridadRepository : ISeguridadRepository
    {
        private readonly IUnitOfWork _unitOfWork;

        public SeguridadRepository(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
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
            var model = _unitOfWork.ContextSirec.VwAplicacionesPermisos
                .Join(_unitOfWork.ContextSirec.AplicacionesModulosPerfilesAplicacionLogins, perm => perm.ModulosPerfilesId, perf => perf.AplicacionesModulosPerfilId, (perm, perf) => new { perm , perf})
                .Where(x => x.perm.AplicacionId == request.AplicacionId &&
                            x.perm.PerfilId == request.PerfilId &&
                            x.perm.ModuloId == request.ModuloId &&
                            x.perf.AplicacionLoginId == request.LoginId)
                .Distinct()
                .Select(x => new PermisosAccionesPorEstadosDto
                {
                    EstadoId = x.perm.EstadoId,
                    Estado = x.perm.Estado,
                    AccionId = x.perm.AccionId,
                    Accion = x.perm.Accion,
                    NumeroAccion = x.perm.NumeroAccion
                }).ToList();

            return model;
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
            var model = _unitOfWork.ContextSirec.VwAplicacionesPermisos
                .Join(_unitOfWork.ContextSirec.AplicacionesModulosPerfilesAplicacionLogins, perm => perm.ModulosPerfilesId, perf => perf.AplicacionesModulosPerfilId, (perm, perf) => new { perm, perf })
                .Where(x => x.perm.AplicacionId == request.AplicacionId &&
                            x.perm.PerfilId == request.PerfilId &&
                            x.perm.ModuloId == request.ModuloId &&
                            x.perf.AplicacionLoginId == request.LoginId)
                .Select(x => new PermisosEstadosPorPerfilModuloDto
                {
                    EstadoId = x.perm.EstadoId,
                    Estado = x.perm.Estado,
                })
                .Distinct()
                .ToList();

            return model;
        }
    }
}
