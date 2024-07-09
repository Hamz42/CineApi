using System;
using System.Collections.Generic;

namespace MC.Cine.DAL.Data.Context.SirecV2.Entities;

public partial class AgentesTiposAgente
{
    public int Id { get; set; }

    public int AgenteId { get; set; }

    public int AgenteTipoId { get; set; }

    public DateTime FechaAlta { get; set; }

    public DateTime? FechaBaja { get; set; }

    public virtual Agente Agente { get; set; } = null!;

    public virtual AgentesTipo AgenteTipo { get; set; } = null!;

    public virtual ICollection<AgentesTiposAgentesPersona> AgentesTiposAgentesPersonas { get; set; } = new List<AgentesTiposAgentesPersona>();

    public virtual ICollection<Tramite> Tramites { get; set; } = new List<Tramite>();
}
