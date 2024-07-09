using System;
using System.Collections.Generic;

namespace MC.Cine.DAL.Data.Context.SirecV2.Entities;

public partial class AplicacionesTipoFormatoRodaje
{
    public int Id { get; set; }

    public string TipoFormato { get; set; } = null!;

    public DateTime FechaAlta { get; set; }

    public DateTime? FechaBaja { get; set; }

    public virtual ICollection<AplicacionesFormatoRodaje> AplicacionesFormatoRodajes { get; set; } = new List<AplicacionesFormatoRodaje>();
}
