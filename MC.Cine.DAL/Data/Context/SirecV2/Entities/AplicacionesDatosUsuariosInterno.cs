using System;
using System.Collections.Generic;

namespace MC.Cine.DAL.Data.Context.SirecV2.Entities;

public partial class AplicacionesDatosUsuariosInterno
{
    public int Id { get; set; }

    public int AplicacionPersonasId { get; set; }

    public string? Cargo { get; set; }

    public virtual AplicacionesPersona AplicacionPersonas { get; set; } = null!;
}
