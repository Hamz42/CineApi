using System;
using System.Collections.Generic;

namespace MC.Cine.DAL.Data.Context.SirecV2.Entities;

public partial class TramitesPersona
{
    public int Id { get; set; }

    public long TramitesId { get; set; }

    public int AgentesProfesionId { get; set; }

    public virtual AgentesProfesion AgentesProfesion { get; set; } = null!;

    public virtual Tramite Tramites { get; set; } = null!;
}
