using System;
using System.Collections.Generic;

namespace MC.Cine.API.Data.Context.SirecV2.Entities;

public partial class AplicacionesModulosPerfilesAplicacionLogin
{
    public int Id { get; set; }

    public int AplicacionesModulosPerfilId { get; set; }

    public int AplicacionLoginId { get; set; }

    public virtual AplicacionesLogin AplicacionLogin { get; set; } = null!;

    public virtual AplicacionesModulosPerfile AplicacionesModulosPerfil { get; set; } = null!;
}
