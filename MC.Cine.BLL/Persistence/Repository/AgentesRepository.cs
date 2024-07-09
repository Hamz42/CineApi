using MC.Cine.BLL.Interfaces.Common.Base;
using MC.Cine.BLL.Interfaces.Repository;
using MC.Cine.BLL.Persistence.Base;
using MC.Cine.BLL.Persistence.Repository.Base;
using MC.Cine.DAL.Data.Context.SirecV2.Entities;
using MC.Cine.DTO.Dto.Agentes;
using System.Data.Entity;

namespace MC.Cine.BLL.Persistence.Repository
{
    public class AgentesRepository : IAgentesRepository
    {
        private readonly IUnitOfWork _unitOfWork;
        public AgentesRepository(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public IEnumerable<AgentesDatosBasicosDto> GetAllByAgenteTipo(int agenteTipoId)
        {
            var fechaActual = DateTime.Now; 
            var model = _unitOfWork.ContextSirec.Agentes
                .AsNoTracking()
                .Where(x => x.AgentesTiposAgentes.Any(t => t.AgenteTipoId == agenteTipoId && (!t.FechaBaja.HasValue || t.FechaBaja > fechaActual)))
                .Select(x => new AgentesDatosBasicosDto
                {
                    Id = x.Id,
                    Identificacion = x.Identificacion,
                    TipoIdentificacion = x.TipoIdentificacion.TipoIdentificacion,
                    TipoIdentificacionId = x.TipoIdentificacionId,
                    AgenteTipoId = x.AgentesTiposAgentes.FirstOrDefault()!.AgenteTipoId,
                    NombreRazonSocial = x.AgentesNaturales.Any(n => !n.FechaBaja.HasValue || n.FechaBaja > fechaActual) ?
                        x.AgentesNaturales.FirstOrDefault(n => !n.FechaBaja.HasValue || n.FechaBaja > fechaActual)!.Nombres + " " + x.AgentesNaturales.FirstOrDefault(n => !n.FechaBaja.HasValue || n.FechaBaja > fechaActual)!.Apellidos :
                        x.AgentesJuridicos.FirstOrDefault(j => !j.FechaBaja.HasValue || j.FechaBaja > fechaActual)!.RazonSocial,
                    AgenteTipo = x.AgentesTiposAgentes.FirstOrDefault()!.AgenteTipo.AgenteTipo
                })
                .ToList();
            return model;
        }
    }
}
