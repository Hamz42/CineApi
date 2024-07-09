using System;
using System.Collections.Generic;

namespace MC.Cine.DAL.Data.Context.SirecV2.Entities;

public partial class AgentesJuridico
{
    public int Id { get; set; }

    public int AgenteId { get; set; }

    public string RazonSocial { get; set; } = null!;

    public string? DigitoVerificacion { get; set; }

    public int? JuridicoTipoId { get; set; }

    public string? UrlPaginaWeb { get; set; }

    public DateTime FechaAlta { get; set; }

    public DateTime? FechaBaja { get; set; }

    public virtual Agente Agente { get; set; } = null!;

    public virtual ICollection<AgentesJuridicosRepresentanteLegal> AgentesJuridicosRepresentanteLegals { get; set; } = new List<AgentesJuridicosRepresentanteLegal>();

    public virtual AgentesJuridicosTipo? JuridicoTipo { get; set; }
}
