using System;
using System.Collections.Generic;

namespace MC.Cine.DAL.Data.Context.SirecV2.Entities;

public partial class AgentesConsejoDepartamental
{
    public int Id { get; set; }

    public int AgenteId { get; set; }

    public int MunicipioId { get; set; }

    public virtual Agente Agente { get; set; } = null!;
}
