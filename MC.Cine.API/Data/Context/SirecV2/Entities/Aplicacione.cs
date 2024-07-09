using System;
using System.Collections.Generic;

namespace MC.Cine.API.Data.Context.SirecV2.Entities;

public partial class Aplicacione
{
    public int Id { get; set; }

    public string Aplicacion { get; set; } = null!;

    public virtual ICollection<AplicacionesModulosPerfile> AplicacionesModulosPerfiles { get; set; } = new List<AplicacionesModulosPerfile>();
}
