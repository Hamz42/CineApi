using System;
using System.Collections.Generic;

namespace MC.Cine.DAL.Data.Context.SirecV2.Entities;

public partial class AgentesTipo
{
    public int Id { get; set; }

    public string AgenteTipo { get; set; } = null!;

    public DateTime FechaAlta { get; set; }

    public DateTime? FechaBaja { get; set; }

    public virtual ICollection<AgentesTiposAgente> AgentesTiposAgentes { get; set; } = new List<AgentesTiposAgente>();
}
