using System;
using System.Collections.Generic;

namespace MC.Cine.API.Data.Context.SirecV2.Entities;

public partial class TramitesClasificacionActum
{
    public int Id { get; set; }

    public DateTime FechaClasificacion { get; set; }

    public int NivelId { get; set; }

    public string? Observaciones { get; set; }

    public DateTime? FechaEstreno { get; set; }

    public int ClasificacionId { get; set; }

    public virtual TramitesClasificacion Clasificacion { get; set; } = null!;

    public virtual TramitesClasificacionNivel Nivel { get; set; } = null!;
}
