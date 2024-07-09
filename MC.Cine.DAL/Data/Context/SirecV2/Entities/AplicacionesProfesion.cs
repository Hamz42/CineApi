using System;
using System.Collections.Generic;

namespace MC.Cine.DAL.Data.Context.SirecV2.Entities;

public partial class AplicacionesProfesion
{
    public int Id { get; set; }

    public string Profesion { get; set; } = null!;

    public virtual ICollection<AgentesProfesion> AgentesProfesions { get; set; } = new List<AgentesProfesion>();
}
