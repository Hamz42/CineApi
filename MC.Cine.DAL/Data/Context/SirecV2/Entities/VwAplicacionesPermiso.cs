using System;
using System.Collections.Generic;

namespace MC.Cine.DAL.Data.Context.SirecV2.Entities;

public partial class VwAplicacionesPermiso
{
    public int ModulosPerfilesId { get; set; }

    public string Aplicacion { get; set; } = null!;

    public int AplicacionId { get; set; }

    public string Modulo { get; set; } = null!;

    public int ModuloId { get; set; }

    public string Perfil { get; set; } = null!;

    public int PerfilId { get; set; }

    public string Estado { get; set; } = null!;

    public int EstadoId { get; set; }

    public string Accion { get; set; } = null!;

    public int NumeroAccion { get; set; }

    public int AccionId { get; set; }
}
