using System;
using System.Collections.Generic;

namespace MC.Cine.API.Data.Context.SirecV2.Entities;

public partial class AplicacionesPersonasJuridica
{
    public int Id { get; set; }

    public int AplicacionPersonaId { get; set; }

    public int JuridicoId { get; set; }

    public virtual AplicacionesPersona AplicacionPersona { get; set; } = null!;

    public virtual Juridico Juridico { get; set; } = null!;
}
