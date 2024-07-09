using System;
using System.Collections.Generic;

namespace MC.Cine.DAL.Data.Context.SirecV2.Entities;

public partial class TipoProduccionCategorium
{
    public int Id { get; set; }

    public string? TipoCategoria { get; set; }

    public virtual ICollection<TramitesProducto> TramitesProductos { get; set; } = new List<TramitesProducto>();
}
