using System;
using System.Collections.Generic;

namespace MC.Cine.API.Data.Context.SirecV2.Entities;

public partial class TramitesProducto
{
    public int Id { get; set; }

    public long TramiteId { get; set; }

    public int? ProyectoId { get; set; }

    public virtual TramitesProyecto? Proyecto { get; set; }

    public virtual Tramite Tramite { get; set; } = null!;

    public virtual ICollection<TramitesClasificacion> TramitesClasificacions { get; set; } = new List<TramitesClasificacion>();
}
