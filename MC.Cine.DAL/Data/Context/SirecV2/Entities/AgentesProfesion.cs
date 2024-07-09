using System;
using System.Collections.Generic;

namespace MC.Cine.DAL.Data.Context.SirecV2.Entities;

public partial class AgentesProfesion
{
    public int Id { get; set; }

    public int AgenteId { get; set; }

    public int ProfesionId { get; set; }

    public virtual Agente Agente { get; set; } = null!;

    public virtual AplicacionesProfesion Profesion { get; set; } = null!;

    public virtual ICollection<TramitesPersona> TramitesPersonas { get; set; } = new List<TramitesPersona>();
}
