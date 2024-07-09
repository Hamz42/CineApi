using System;
using System.Collections.Generic;

namespace MC.Cine.DAL.Data.Context.SirecV2.Entities;

public partial class AplicacionesMonedum
{
    public int Id { get; set; }

    public string Moneda { get; set; } = null!;

    public string Descripcion { get; set; } = null!;

    public DateTime FechaAlta { get; set; }

    public DateTime? FechaBaja { get; set; }

    public virtual ICollection<TramitesClasificacion> TramitesClasificacions { get; set; } = new List<TramitesClasificacion>();
}
