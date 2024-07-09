using System;
using System.Collections.Generic;

namespace MC.Cine.API.Data.Context.SirecV2.Entities;

public partial class AplicacionesEstadoTramite
{
    public int IdAplicacionesEstadoTramite { get; set; }

    public string? EstadoNombre { get; set; }

    public int? AplicacionesId { get; set; }

    public virtual Aplicacione? Aplicaciones { get; set; }
}
