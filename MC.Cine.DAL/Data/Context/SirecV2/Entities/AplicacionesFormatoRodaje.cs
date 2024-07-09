using System;
using System.Collections.Generic;

namespace MC.Cine.DAL.Data.Context.SirecV2.Entities;

public partial class AplicacionesFormatoRodaje
{
    public int Id { get; set; }

    public int TipoFormatoId { get; set; }

    public string FormatoRodaje { get; set; } = null!;

    public DateTime FechaAlta { get; set; }

    public DateTime? FechaBaja { get; set; }

    public virtual AplicacionesTipoFormatoRodaje TipoFormato { get; set; } = null!;

    public virtual ICollection<TramitesClasificacion> TramitesClasificacions { get; set; } = new List<TramitesClasificacion>();
}
