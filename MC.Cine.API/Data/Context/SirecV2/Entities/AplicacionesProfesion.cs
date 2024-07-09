using System;
using System.Collections.Generic;

namespace MC.Cine.API.Data.Context.SirecV2.Entities;

public partial class AplicacionesProfesion
{
    public int Id { get; set; }

    public string Profesion { get; set; } = null!;

    public virtual ICollection<AplicacionesPersonasProfesion> AplicacionesPersonasProfesions { get; set; } = new List<AplicacionesPersonasProfesion>();
}
