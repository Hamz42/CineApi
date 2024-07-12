using System;
using System.Collections.Generic;

namespace MC.Cine.DAL.Data.Context.SirecV2.Entities;

public partial class AplicacionesSubGenero
{
    public int Id { get; set; }

    public int GeneroObraId { get; set; }

    public string SubGenero { get; set; } = null!;

    public DateTime FechaAlta { get; set; }

    public DateTime? FechaBaja { get; set; }

    public virtual AplicacionesGeneroObra GeneroObra { get; set; } = null!;
}
