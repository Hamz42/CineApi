using System;
using System.Collections.Generic;

namespace MC.Cine.API.Data.Context.SirecV2.Entities;

public partial class AplicacionesModulosPerfile
{
    public int Id { get; set; }

    public int AplicacionId { get; set; }

    public int AplicacionesModuloId { get; set; }

    public int AplicacionesPerfilId { get; set; }

    public virtual Aplicacione Aplicacion { get; set; } = null!;

    public virtual AplicacionesModulo AplicacionesModulo { get; set; } = null!;

    public virtual ICollection<AplicacionesModulosEstadosAccione> AplicacionesModulosEstadosAcciones { get; set; } = new List<AplicacionesModulosEstadosAccione>();

    public virtual ICollection<AplicacionesModulosPerfilesAplicacionLogin> AplicacionesModulosPerfilesAplicacionLogins { get; set; } = new List<AplicacionesModulosPerfilesAplicacionLogin>();

    public virtual AplicacionesPerfile AplicacionesPerfil { get; set; } = null!;
}
