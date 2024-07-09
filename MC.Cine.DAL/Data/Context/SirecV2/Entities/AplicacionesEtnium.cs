using System;
using System.Collections.Generic;

namespace MC.Cine.DAL.Data.Context.SirecV2.Entities;

public partial class AplicacionesEtnium
{
    public int Id { get; set; }

    public string GrupoEtnico { get; set; } = null!;

    public bool RequiereInformacionAdicional { get; set; }

    public DateTime FechaAlta { get; set; }

    public DateTime? FechaBaja { get; set; }

    public virtual ICollection<AgentesEtnium> AgentesEtnia { get; set; } = new List<AgentesEtnium>();
}
