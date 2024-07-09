using System;
using System.Collections.Generic;

namespace MC.Cine.API.Data.Context.SirecV2.Entities;

public partial class AplicacionesModulosEstadosAccione
{
    public int Id { get; set; }

    public int AplicacionesEstadoId { get; set; }

    public int AplicacionesAccionId { get; set; }

    public int AplicacionesModulosPerfilId { get; set; }

    public virtual AplicacionesAccione AplicacionesAccion { get; set; } = null!;

    public virtual AplicacionesEstado AplicacionesEstado { get; set; } = null!;

    public virtual AplicacionesModulosPerfile AplicacionesModulosPerfil { get; set; } = null!;
}
