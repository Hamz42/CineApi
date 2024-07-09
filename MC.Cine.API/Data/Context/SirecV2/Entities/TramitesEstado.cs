using System;
using System.Collections.Generic;

namespace MC.Cine.API.Data.Context.SirecV2.Entities;

public partial class TramitesEstado
{
    public int Id { get; set; }

    public long TramiteId { get; set; }

    public int EstadoId { get; set; }

    public virtual Tramite Tramite { get; set; } = null!;
}
