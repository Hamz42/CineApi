using System;
using System.Collections.Generic;

namespace MC.Cine.API.Data.Context.SirecV2.Entities;

public partial class AplicacionesAccione
{
    public int Id { get; set; }

    public string Accion { get; set; } = null!;

    public int NumeroAccion { get; set; }

    public virtual ICollection<AplicacionesModulosEstadosAccione> AplicacionesModulosEstadosAcciones { get; set; } = new List<AplicacionesModulosEstadosAccione>();
}
