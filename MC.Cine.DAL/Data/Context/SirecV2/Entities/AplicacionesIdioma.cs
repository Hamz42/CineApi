using System;
using System.Collections.Generic;

namespace MC.Cine.DAL.Data.Context.SirecV2.Entities;

public partial class AplicacionesIdioma
{
    public int Id { get; set; }

    public string Idioma { get; set; } = null!;
}
