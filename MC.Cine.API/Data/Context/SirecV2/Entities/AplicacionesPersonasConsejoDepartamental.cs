using System;
using System.Collections.Generic;

namespace MC.Cine.API.Data.Context.SirecV2.Entities;

public partial class AplicacionesPersonasConsejoDepartamental
{
    public int Id { get; set; }

    public int AplicacionPersonaId { get; set; }

    public int ConsejoDepartamentalId { get; set; }

    public virtual AplicacionesPersona AplicacionPersona { get; set; } = null!;

    public virtual ConsejoDepartamental ConsejoDepartamental { get; set; } = null!;
}
