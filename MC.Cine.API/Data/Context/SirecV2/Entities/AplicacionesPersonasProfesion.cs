using System;
using System.Collections.Generic;

namespace MC.Cine.API.Data.Context.SirecV2.Entities;

public partial class AplicacionesPersonasProfesion
{
    public int Id { get; set; }

    public int AplicacionPersonaId { get; set; }

    public int AplicacionProfesionId { get; set; }

    public virtual AplicacionesPersona AplicacionPersona { get; set; } = null!;

    public virtual AplicacionesProfesion AplicacionProfesion { get; set; } = null!;
}
