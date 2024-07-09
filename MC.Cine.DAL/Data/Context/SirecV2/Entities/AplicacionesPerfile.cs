using System;
using System.Collections.Generic;

namespace MC.Cine.DAL.Data.Context.SirecV2.Entities;

public partial class AplicacionesPerfile
{
    public int Id { get; set; }

    public string Perfil { get; set; } = null!;

    public virtual ICollection<AplicacionesModulosPerfile> AplicacionesModulosPerfiles { get; set; } = new List<AplicacionesModulosPerfile>();
}
