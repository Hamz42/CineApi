using System;
using System.Collections.Generic;

namespace MC.Cine.DAL.Data.Context.SirecV2.Entities;

public partial class AplicacionesTipoTelefono
{
    public int Id { get; set; }

    public string TipoTelefono { get; set; } = null!;

    public virtual ICollection<AplicacionesPersonasTelefono> AplicacionesPersonasTelefonos { get; set; } = new List<AplicacionesPersonasTelefono>();
}
