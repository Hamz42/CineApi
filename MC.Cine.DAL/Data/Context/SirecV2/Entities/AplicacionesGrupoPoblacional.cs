using System;
using System.Collections.Generic;

namespace MC.Cine.DAL.Data.Context.SirecV2.Entities;

public partial class AplicacionesGrupoPoblacional
{
    public int Id { get; set; }

    public string GrupoPoblacional { get; set; } = null!;

    public DateTime FechaAlta { get; set; }

    public DateTime? FechaBaja { get; set; }

    public virtual ICollection<AgentesGrupoPoblacional> AgentesGrupoPoblacionals { get; set; } = new List<AgentesGrupoPoblacional>();
}
