using System;
using System.Collections.Generic;

namespace MC.Cine.API.Data.Context.SirecV2.Entities;

public partial class AplicacionesGeneroObra
{
    public int Id { get; set; }

    public string Genero { get; set; } = null!;

    public DateTime FechaAlta { get; set; }

    public DateTime? FechaBaja { get; set; }

    public virtual ICollection<TramitesClasificacion> TramitesClasificacions { get; set; } = new List<TramitesClasificacion>();
}
