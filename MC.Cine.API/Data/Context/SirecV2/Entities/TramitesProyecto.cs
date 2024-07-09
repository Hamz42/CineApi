using System;
using System.Collections.Generic;

namespace MC.Cine.API.Data.Context.SirecV2.Entities;

public partial class TramitesProyecto
{
    public int Id { get; set; }

    public long TramiteId { get; set; }

    public virtual Tramite Tramite { get; set; } = null!;

    public virtual ICollection<TramitesProducto> TramitesProductos { get; set; } = new List<TramitesProducto>();
}
