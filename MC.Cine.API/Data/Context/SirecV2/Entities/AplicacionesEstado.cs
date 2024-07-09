using System;
using System.Collections.Generic;

namespace MC.Cine.API.Data.Context.SirecV2.Entities;

public partial class AplicacionesEstado
{
    public int Id { get; set; }

    public string Estado { get; set; } = null!;

    public virtual ICollection<AplicacionesModulosEstadosAccione> AplicacionesModulosEstadosAcciones { get; set; } = new List<AplicacionesModulosEstadosAccione>();
}
