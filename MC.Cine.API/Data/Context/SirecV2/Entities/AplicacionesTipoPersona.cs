using System;
using System.Collections.Generic;

namespace MC.Cine.API.Data.Context.SirecV2.Entities;

public partial class AplicacionesTipoPersona
{
    public int Id { get; set; }

    public string TipoPersona { get; set; } = null!;

    public virtual ICollection<AplicacionesPersona> AplicacionesPersonas { get; set; } = new List<AplicacionesPersona>();
}
