using MC.Cine.BLL.Interfaces.Common.Base;
using MC.Cine.BLL.Interfaces.Repository;
using MC.Cine.DTO.Dto.Proyecto;
using System.Data.Entity;

namespace MC.Cine.BLL.Persistence.Repository
{
    public class ProyectoRepository : IProyectoRepository
    {
        private readonly IUnitOfWork _unitOfWork;

        public ProyectoRepository(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public IEnumerable<ProyectoDto> GetAllFiltros(FiltroRequest request)
        {
            var model = _unitOfWork.ContextSirec.Proyectos.AsNoTracking();

            if (!string.IsNullOrEmpty(request.IdCreador.ToString()))
            {
                model = model.Where(x => x.ConcursanteId == request.IdCreador);
            }

            if (!string.IsNullOrEmpty(request.NombreProyecto))
            {
                model = model.Where(x => x.ProyectoNombre.Contains(request.NombreProyecto));
            }

            return model.Select(x => new ProyectoDto
            {
                Id = x.ProyectoId,
                IdEstado = x.ProyectoEstado.ProyectoEstadoId,
                Estado = x.ProyectoEstado.ProyectoEstadoNombre ?? string.Empty,
                NombreProyecto = x.ProyectoNombre,
                FechaSolicitud = x.ProyectoFechaRadicado,
                FechaSolicitudAclaraciones = x.ProyectoFechaGuia,
                FechaReciboAclaraciones = x.ProyectoFechaGuia
            }).ToList();
        }
    }
}
