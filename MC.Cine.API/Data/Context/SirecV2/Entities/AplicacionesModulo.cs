using System;
using System.Collections.Generic;

namespace MC.Cine.API.Data.Context.SirecV2.Entities;

public partial class AplicacionesModulo
{
    public int Id { get; set; }

    public string Modulo { get; set; } = null!;

    public virtual ICollection<AplicacionesModulosPerfile> AplicacionesModulosPerfiles { get; set; } = new List<AplicacionesModulosPerfile>();
}
