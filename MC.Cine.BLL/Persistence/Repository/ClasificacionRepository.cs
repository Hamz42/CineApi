using MC.Cine.BLL.Interfaces.Common.Base;
using MC.Cine.BLL.Interfaces.Repository;
using MC.Cine.DTO.Dto.Acciones;
using MC.Cine.DTO.Dto.Clasificacion;
using MC.Cine.DTO.Dto.Seguridad;
using System.Data.Entity;
using static MC.Cine.BLL.Config.AplicacionesConfig;

namespace MC.Cine.BLL.Persistence.Repository
{
    public class ClasificacionRepository : IClasificacionRepository
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly ISeguridadRepository _seguridadRepository;

        public ClasificacionRepository(IUnitOfWork unitOfWork, ISeguridadRepository seguridadRepository)
        {
            _unitOfWork = unitOfWork;
            _seguridadRepository = seguridadRepository;
        }

        public IEnumerable<ClasificacionDto> GetAllFiltros(FiltroClasificacionRequest request)
        {
            var acciones = _seguridadRepository.GetAccionesPorEstados(new PermisosRequest
            {
                AplicacionId = (int)AplicacionesEnum.Sirec,
                ModuloId = (int)ModulosEnum.Clasificacion,
                PerfilId = (int)request.PerfilId!,
                LoginId = (int)request.IdCreador!
            }).Select(a => new AccionesDto
            {
                Id = a.AccionId,
                Accion = a.Accion,
                NumeroAccion = a.NumeroAccion,
                IdEstado = a.EstadoId
            });

            var model = _unitOfWork.ContextSirec.TramitesClasificacions
                .Join(_unitOfWork.ContextSirec.AplicacionesEstados, cla => cla.Tramite.EstadoId, est => est.Id, (cla, est) => new {cla , est})
                .AsNoTracking();

            if (request.FechaSolicitudInicio.HasValue && request.FechaSolicitudFin.HasValue)
            {
                model = model.Where(x => x.cla.Tramite.FechaSolicitud >= request.FechaSolicitudInicio && x.cla.Tramite.FechaSolicitud <= request.FechaSolicitudFin);
            }

            if (request.IdCreador.HasValue)
            {
                model = model.Where(x => x.cla.Tramite.LoginId == request.IdCreador);
            }

            if (!string.IsNullOrEmpty(request.Obra))
            {
                model = model.Where(x => (x.cla.TituloOriginal ?? "").ToLower().Trim().Contains(request.Obra.ToLower().Trim()) ||
                (x.cla.TituloEspañol ?? "").ToLower().Trim().Contains(request.Obra.ToLower().Trim()));
            }

            //if (!string.IsNullOrEmpty(request.Responsable))
            //{
            //    model = model.Where(x =>
            //                        string.Join(" ",
            //                            (x.AgeNombresRepLegal ?? "").Trim(),
            //                            (x.AgeSegundoNombresRepLegal ?? "").Trim(),
            //                            (x.AgeApellidosRepLegal ?? "").Trim(),
            //                            (x.AgeSegundoApellidosRepLegal ?? "").Trim())
            //                        .ToLower()
            //                        .Contains(request.Responsable.ToLower().Trim()));
            //}

            if (request.IdNivelClasificacion.HasValue)
            {
                model = model.Where(x => x.cla.TramitesClasificacionActa.Any(a => a.NivelId == (int)request.IdNivelClasificacion));
            }

            if (request.IdEstado.HasValue)
            {
                model = model.Where(x => x.cla.Tramite.EstadoId == request.IdEstado);
            }

            var result = model.Select(x => new ClasificacionDto
                {
                   Id = x.cla.Id,
                   TramiteId = x.cla.TramiteId,
                   EstadoId = x.cla.Tramite.EstadoId,
                   Estado = x.est.Estado,
                   Obra = x.cla.TituloOriginal,
                   Fecha = x.cla.Tramite.FechaSolicitud,
                   FechaClasificacion = x.cla.TramitesClasificacionActa.FirstOrDefault()!.FechaClasificacion,
                   NivelClasificacion = x.cla.TramitesClasificacionActa.FirstOrDefault()!.Nivel.Nivel!
                })
                .OrderByDescending(x => x.Id)
                .ToList();

            result.ForEach(x =>
            {
                x.Acciones = acciones.Where(a => a.IdEstado == x.EstadoId).ToList();
            });

            return result;
        }
    }
}
