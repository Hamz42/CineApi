using System;
using System.Collections.Generic;

namespace MC.Cine.DAL.Data.Context.SirecV2.Entities;

public partial class AgentesGrupoPoblacional
{
    public int Id { get; set; }

    public int AgenteId { get; set; }

    public int GrupoPoblacionalId { get; set; }

    public DateTime FechaAlta { get; set; }

    public DateTime? FechaBaja { get; set; }

    public virtual Agente Agente { get; set; } = null!;

    public virtual AplicacionesGrupoPoblacional GrupoPoblacional { get; set; } = null!;
}
